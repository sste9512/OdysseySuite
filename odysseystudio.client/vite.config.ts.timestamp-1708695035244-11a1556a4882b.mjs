// vite.config.ts
import { fileURLToPath, URL } from "node:url";
import { defineConfig } from "file:///C:/Users/steve/RiderProjects/MAIN/OdysseyStudio/odysseystudio.client/node_modules/vite/dist/node/index.js";
import plugin from "file:///C:/Users/steve/RiderProjects/MAIN/OdysseyStudio/odysseystudio.client/node_modules/@vitejs/plugin-vue/dist/index.mjs";
import fs from "fs";
import path from "path";
import child_process from "child_process";
var __vite_injected_original_import_meta_url = "file:///C:/Users/steve/RiderProjects/MAIN/OdysseyStudio/odysseystudio.client/vite.config.ts";
var baseFolder = process.env.APPDATA !== void 0 && process.env.APPDATA !== "" ? `${process.env.APPDATA}/ASP.NET/https` : `${process.env.HOME}/.aspnet/https`;
var certificateArg = process.argv.map((arg) => arg.match(/--name=(?<value>.+)/i)).filter(Boolean)[0];
var certificateName = certificateArg ? certificateArg.groups.value : "odysseystudio.client";
if (!certificateName) {
  console.error("Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly.");
  process.exit(-1);
}
var certFilePath = path.join(baseFolder, `${certificateName}.pem`);
var keyFilePath = path.join(baseFolder, `${certificateName}.key`);
if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
  if (0 !== child_process.spawnSync("dotnet", [
    "dev-certs",
    "https",
    "--export-path",
    certFilePath,
    "--format",
    "Pem",
    "--no-password"
  ], { stdio: "inherit" }).status) {
    throw new Error("Could not create certificate.");
  }
}
var vite_config_default = defineConfig({
  plugins: [plugin()],
  resolve: {
    alias: {
      "@": fileURLToPath(new URL("./src", __vite_injected_original_import_meta_url))
    }
  },
  server: {
    proxy: {
      "^/weatherforecast": {
        target: "https://localhost:7297/",
        secure: false
      }
    },
    port: 5173,
    https: {
      key: fs.readFileSync(keyFilePath),
      cert: fs.readFileSync(certFilePath)
    }
  }
});
export {
  vite_config_default as default
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsidml0ZS5jb25maWcudHMiXSwKICAic291cmNlc0NvbnRlbnQiOiBbImNvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9kaXJuYW1lID0gXCJDOlxcXFxVc2Vyc1xcXFxzdGV2ZVxcXFxSaWRlclByb2plY3RzXFxcXE1BSU5cXFxcT2R5c3NleVN0dWRpb1xcXFxvZHlzc2V5c3R1ZGlvLmNsaWVudFwiO2NvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9maWxlbmFtZSA9IFwiQzpcXFxcVXNlcnNcXFxcc3RldmVcXFxcUmlkZXJQcm9qZWN0c1xcXFxNQUlOXFxcXE9keXNzZXlTdHVkaW9cXFxcb2R5c3NleXN0dWRpby5jbGllbnRcXFxcdml0ZS5jb25maWcudHNcIjtjb25zdCBfX3ZpdGVfaW5qZWN0ZWRfb3JpZ2luYWxfaW1wb3J0X21ldGFfdXJsID0gXCJmaWxlOi8vL0M6L1VzZXJzL3N0ZXZlL1JpZGVyUHJvamVjdHMvTUFJTi9PZHlzc2V5U3R1ZGlvL29keXNzZXlzdHVkaW8uY2xpZW50L3ZpdGUuY29uZmlnLnRzXCI7aW1wb3J0IHsgZmlsZVVSTFRvUGF0aCwgVVJMIH0gZnJvbSAnbm9kZTp1cmwnO1xyXG5cclxuaW1wb3J0IHsgZGVmaW5lQ29uZmlnIH0gZnJvbSAndml0ZSc7XHJcbmltcG9ydCBwbHVnaW4gZnJvbSAnQHZpdGVqcy9wbHVnaW4tdnVlJztcclxuaW1wb3J0IGZzIGZyb20gJ2ZzJztcclxuaW1wb3J0IHBhdGggZnJvbSAncGF0aCc7XHJcbmltcG9ydCBjaGlsZF9wcm9jZXNzIGZyb20gJ2NoaWxkX3Byb2Nlc3MnO1xyXG5cclxuY29uc3QgYmFzZUZvbGRlciA9XHJcbiAgICBwcm9jZXNzLmVudi5BUFBEQVRBICE9PSB1bmRlZmluZWQgJiYgcHJvY2Vzcy5lbnYuQVBQREFUQSAhPT0gJydcclxuICAgICAgICA/IGAke3Byb2Nlc3MuZW52LkFQUERBVEF9L0FTUC5ORVQvaHR0cHNgXHJcbiAgICAgICAgOiBgJHtwcm9jZXNzLmVudi5IT01FfS8uYXNwbmV0L2h0dHBzYDtcclxuXHJcbmNvbnN0IGNlcnRpZmljYXRlQXJnID0gcHJvY2Vzcy5hcmd2Lm1hcChhcmcgPT4gYXJnLm1hdGNoKC8tLW5hbWU9KD88dmFsdWU+LispL2kpKS5maWx0ZXIoQm9vbGVhbilbMF07XHJcbmNvbnN0IGNlcnRpZmljYXRlTmFtZSA9IGNlcnRpZmljYXRlQXJnID8gY2VydGlmaWNhdGVBcmcuZ3JvdXBzLnZhbHVlIDogXCJvZHlzc2V5c3R1ZGlvLmNsaWVudFwiO1xyXG5cclxuaWYgKCFjZXJ0aWZpY2F0ZU5hbWUpIHtcclxuICAgIGNvbnNvbGUuZXJyb3IoJ0ludmFsaWQgY2VydGlmaWNhdGUgbmFtZS4gUnVuIHRoaXMgc2NyaXB0IGluIHRoZSBjb250ZXh0IG9mIGFuIG5wbS95YXJuIHNjcmlwdCBvciBwYXNzIC0tbmFtZT08PGFwcD4+IGV4cGxpY2l0bHkuJylcclxuICAgIHByb2Nlc3MuZXhpdCgtMSk7XHJcbn1cclxuXHJcbmNvbnN0IGNlcnRGaWxlUGF0aCA9IHBhdGguam9pbihiYXNlRm9sZGVyLCBgJHtjZXJ0aWZpY2F0ZU5hbWV9LnBlbWApO1xyXG5jb25zdCBrZXlGaWxlUGF0aCA9IHBhdGguam9pbihiYXNlRm9sZGVyLCBgJHtjZXJ0aWZpY2F0ZU5hbWV9LmtleWApO1xyXG5cclxuaWYgKCFmcy5leGlzdHNTeW5jKGNlcnRGaWxlUGF0aCkgfHwgIWZzLmV4aXN0c1N5bmMoa2V5RmlsZVBhdGgpKSB7XHJcbiAgICBpZiAoMCAhPT0gY2hpbGRfcHJvY2Vzcy5zcGF3blN5bmMoJ2RvdG5ldCcsIFtcclxuICAgICAgICAnZGV2LWNlcnRzJyxcclxuICAgICAgICAnaHR0cHMnLFxyXG4gICAgICAgICctLWV4cG9ydC1wYXRoJyxcclxuICAgICAgICBjZXJ0RmlsZVBhdGgsXHJcbiAgICAgICAgJy0tZm9ybWF0JyxcclxuICAgICAgICAnUGVtJyxcclxuICAgICAgICAnLS1uby1wYXNzd29yZCcsXHJcbiAgICBdLCB7IHN0ZGlvOiAnaW5oZXJpdCcsIH0pLnN0YXR1cykge1xyXG4gICAgICAgIHRocm93IG5ldyBFcnJvcihcIkNvdWxkIG5vdCBjcmVhdGUgY2VydGlmaWNhdGUuXCIpO1xyXG4gICAgfVxyXG59XHJcblxyXG4vLyBodHRwczovL3ZpdGVqcy5kZXYvY29uZmlnL1xyXG5leHBvcnQgZGVmYXVsdCBkZWZpbmVDb25maWcoe1xyXG4gICAgcGx1Z2luczogW3BsdWdpbigpXSxcclxuICAgIHJlc29sdmU6IHtcclxuICAgICAgICBhbGlhczoge1xyXG4gICAgICAgICAgICAnQCc6IGZpbGVVUkxUb1BhdGgobmV3IFVSTCgnLi9zcmMnLCBpbXBvcnQubWV0YS51cmwpKVxyXG4gICAgICAgIH1cclxuICAgIH0sXHJcbiAgICBzZXJ2ZXI6IHtcclxuICAgICAgICBwcm94eToge1xyXG4gICAgICAgICAgICAnXi93ZWF0aGVyZm9yZWNhc3QnOiB7XHJcbiAgICAgICAgICAgICAgICB0YXJnZXQ6ICdodHRwczovL2xvY2FsaG9zdDo3Mjk3LycsXHJcbiAgICAgICAgICAgICAgICBzZWN1cmU6IGZhbHNlXHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9LFxyXG4gICAgICAgIHBvcnQ6IDUxNzMsXHJcbiAgICAgICAgaHR0cHM6IHtcclxuICAgICAgICAgICAga2V5OiBmcy5yZWFkRmlsZVN5bmMoa2V5RmlsZVBhdGgpLFxyXG4gICAgICAgICAgICBjZXJ0OiBmcy5yZWFkRmlsZVN5bmMoY2VydEZpbGVQYXRoKSxcclxuICAgICAgICB9XHJcbiAgICB9XHJcbn0pXHJcbiJdLAogICJtYXBwaW5ncyI6ICI7QUFBNFksU0FBUyxlQUFlLFdBQVc7QUFFL2EsU0FBUyxvQkFBb0I7QUFDN0IsT0FBTyxZQUFZO0FBQ25CLE9BQU8sUUFBUTtBQUNmLE9BQU8sVUFBVTtBQUNqQixPQUFPLG1CQUFtQjtBQU5tTyxJQUFNLDJDQUEyQztBQVE5UyxJQUFNLGFBQ0YsUUFBUSxJQUFJLFlBQVksVUFBYSxRQUFRLElBQUksWUFBWSxLQUN2RCxHQUFHLFFBQVEsSUFBSSxPQUFPLG1CQUN0QixHQUFHLFFBQVEsSUFBSSxJQUFJO0FBRTdCLElBQU0saUJBQWlCLFFBQVEsS0FBSyxJQUFJLFNBQU8sSUFBSSxNQUFNLHNCQUFzQixDQUFDLEVBQUUsT0FBTyxPQUFPLEVBQUUsQ0FBQztBQUNuRyxJQUFNLGtCQUFrQixpQkFBaUIsZUFBZSxPQUFPLFFBQVE7QUFFdkUsSUFBSSxDQUFDLGlCQUFpQjtBQUNsQixVQUFRLE1BQU0sbUhBQW1IO0FBQ2pJLFVBQVEsS0FBSyxFQUFFO0FBQ25CO0FBRUEsSUFBTSxlQUFlLEtBQUssS0FBSyxZQUFZLEdBQUcsZUFBZSxNQUFNO0FBQ25FLElBQU0sY0FBYyxLQUFLLEtBQUssWUFBWSxHQUFHLGVBQWUsTUFBTTtBQUVsRSxJQUFJLENBQUMsR0FBRyxXQUFXLFlBQVksS0FBSyxDQUFDLEdBQUcsV0FBVyxXQUFXLEdBQUc7QUFDN0QsTUFBSSxNQUFNLGNBQWMsVUFBVSxVQUFVO0FBQUEsSUFDeEM7QUFBQSxJQUNBO0FBQUEsSUFDQTtBQUFBLElBQ0E7QUFBQSxJQUNBO0FBQUEsSUFDQTtBQUFBLElBQ0E7QUFBQSxFQUNKLEdBQUcsRUFBRSxPQUFPLFVBQVcsQ0FBQyxFQUFFLFFBQVE7QUFDOUIsVUFBTSxJQUFJLE1BQU0sK0JBQStCO0FBQUEsRUFDbkQ7QUFDSjtBQUdBLElBQU8sc0JBQVEsYUFBYTtBQUFBLEVBQ3hCLFNBQVMsQ0FBQyxPQUFPLENBQUM7QUFBQSxFQUNsQixTQUFTO0FBQUEsSUFDTCxPQUFPO0FBQUEsTUFDSCxLQUFLLGNBQWMsSUFBSSxJQUFJLFNBQVMsd0NBQWUsQ0FBQztBQUFBLElBQ3hEO0FBQUEsRUFDSjtBQUFBLEVBQ0EsUUFBUTtBQUFBLElBQ0osT0FBTztBQUFBLE1BQ0gscUJBQXFCO0FBQUEsUUFDakIsUUFBUTtBQUFBLFFBQ1IsUUFBUTtBQUFBLE1BQ1o7QUFBQSxJQUNKO0FBQUEsSUFDQSxNQUFNO0FBQUEsSUFDTixPQUFPO0FBQUEsTUFDSCxLQUFLLEdBQUcsYUFBYSxXQUFXO0FBQUEsTUFDaEMsTUFBTSxHQUFHLGFBQWEsWUFBWTtBQUFBLElBQ3RDO0FBQUEsRUFDSjtBQUNKLENBQUM7IiwKICAibmFtZXMiOiBbXQp9Cg==
