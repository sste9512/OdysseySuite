<script setup lang="ts">

defineProps<{
  title?: string
  show?: boolean
}>()

</script>

<template>
  <v-dialog
      theme="dark"
      :v-model="show"
      min-width="75%"
      width="auto"
      style="z-index: 9999999"
  >
    <v-card class="mx-auto dark-glass" width="75%">
      <v-toolbar
          flat
          height="20px"
          color="teal-darken-4"
          image="https://picsum.photos/1920/1080?random"
      >
        <template v-slot:image>
          <v-img gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"></v-img>
        </template>
        <v-btn icon="mdi-account"></v-btn>

        <v-toolbar-title> Create a project from Game Directory</v-toolbar-title>

        <v-spacer></v-spacer>

<!--        <v-btn icon>
          <v-fade-transition leave-absolute>
            <v-icon v-if="isEditing" size="x-small">mdi-close</v-icon>
          </v-fade-transition>
        </v-btn>-->
      </v-toolbar>

      <v-card-text>
        <v-text-field color="white" label="Name" variant="solo"></v-text-field>

        <div class="file-explorer theme-test folder-tree. folder-indicator">

          <ul>
            <li>
              <details open>
                <summary> <span class="file-icons file-icons-folder"></span> dist </summary>
                <ul>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> assets </summary>
                      <ul>
                        <li> <span class="file-icons file-icons-css"></span> style.min.css </li>
                        <li> <span class="file-icons file-icons-js"></span> script.min.js </li>
                      </ul>
                    </details>
                  </li>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> images </summary>
                      <ul>
                        <li> <span class="file-icons file-icons-none"></span> logo.svg </li>
                        <li> <span class="file-icons file-icons-none"></span> icon.png </li>
                      </ul>
                    </details>
                  </li>
                  <li> <span class="file-icons file-icons-html"></span> index.html </li>
                  <li> <span class="file-icons file-icons-html"></span> about.html </li>
                </ul>
              </details>
            </li>
            <li>
              <details open>
                <summary> <span class="file-icons file-icons-folder"></span> src </summary>
                <ul>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> css </summary>
                      <ul>
                        <li> <span class="file-icons file-icons-css"></span> style.css </li>
                      </ul>
                    </details>
                  </li>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> js </summary>
                      <ul>
                        <li> <span class="file-icons file-icons-js"></span> script.js </li>
                      </ul>
                    </details>
                  </li>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> images </summary>
                      <ul>
                        <li> <span class="file-icons file-icons-none"></span> logo.svg </li>
                        <li> <span class="file-icons file-icons-none"></span> icon.png </li>
                      </ul>
                    </details>
                  </li>
                  <li>
                    <details open>
                      <summary> <span class="file-icons file-icons-folder"></span> pages </summary>
                      <ul>
                        <!-- -->
                        <li>
                          <details open>
                            <summary class="active"> <span class="file-icons file-icons-folder"></span> folder test0 test1 test2 test3 test4 test5 test6 test7 test8 test9 test0 </summary>
                            <ul>
                              <li> <span class="file-icons file-icons-docx"></span> test1 </li>
                              <li class="active"> <span class="file-icons file-icons-xls"></span> file test0 test1 test2 test3 test4 test5 test6 test7 test8 test9 test0 </li>
                            </ul>
                          </details>
                        </li>
                        <!-- -->
                        <li> <span class="file-icons file-icons-html"></span> index.html </li>
                        <li> <span class="file-icons file-icons-html"></span> about.html </li>
                      </ul>
                    </details>
                  </li>
                </ul>
              </details>
            </li>
            <li> <span class="file-icons file-icons-json"></span> package.json </li>
            <li> <span class="file-icons file-icons-none"></span> readme.md </li>
          </ul>

        </div>
      </v-card-text>

      <v-divider></v-divider>

<!--      <v-snackbar
          v-model="hasSaved"
          :timeout="2000"
          attach
          position="absolute"
          location="bottom left"
      >
        Your profile has been updated
      </v-snackbar>-->
      <v-card-actions>
        <v-btn color="primary" block>Finished</v-btn>
      </v-card-actions>
      <v-card-actions>
        <v-btn color="primary" block>Close Dialog</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
  
</template>

<style scoped lang="scss">
.file-explorer {
  --fe-line-height: 1.5rem;

  --fe-folder-indent: 2ch;
  --fe-folder-marker-open: "";
  --fe-folder-marker-close: "";
  --fe-folder-marker-color: currentColor;

  --fe-folder-indicator-indent: 0.25rem;
  --fe-folder-indicator-width: 1px;
  --fe-folder-indicator-style: solid;
  --fe-folder-indicator-color: #666;

  --fe-tree-indent: 0.25rem;
  --fe-tree-width: 1px;
  --fe-tree-style: solid;
  --fe-tree-color: #666;

  --fe-actice-bg-color: transparent;
  --fe-active-text-color: currentColor;

  --fe-hover-bg-color: transparent;
  --fe-hover-text-color: currentColor;

  box-sizing: border-box;
  overflow-y: hidden;
  overflow-x: auto;
  isolation: isolate;

  /* Reset */

  ul,
  li,
  details,
  summary {
    margin: 0;
    padding: 0;
    border: 0;
    text-align: start;
    box-sizing: border-box;
  }

  /* Elements Structure */

  ul {
    display: flex;
    flex-direction: column;
    user-select: none;
  }

  li {
    display: flex;
    justify-content: start;
    align-items: center;
    position: relative;
    width: 100%;
    line-height: var(--fe-line-height);

    overflow: hidden;
    // white-space: nowrap;
    // text-overflow: ellipsis;

    white-space: nowrap;

    ul {
      li {
        padding-inline-start: var(--fe-folder-indent);
      }
    }
  }

  details {
    width: 100%;
  }

  summary {
    display: flex;
    justify-content: start;
    align-items: center;
    cursor: pointer;
    line-height: var(--fe-line-height);
    height: var(--fe-line-height);

    overflow: hidden;
    white-space: nowrap;
    // text-overflow: ellipsis;

    &:focus-visible {
      outline: 1px dotted #000;
    }
  }

  /* Folder Marker */

  summary {
    display: list-item;

    &::marker,
    &::-webkit-details-marker {
      content: var(--fe-folder-marker-open);
      color: var(--fe-folder-marker-color);
    }
  }

  details[open] > summary {
    &::marker,
    &::-webkit-details-marker {
      content: var(--fe-folder-marker-close);
    }
  }

  /* Folder Indicator */

  &.folder-indicator {
    summary + ul {
      padding-inline-start: var(--fe-folder-indicator-indent);

      li {
        border-inline-start: var(--fe-folder-indicator-width)
        var(--fe-folder-indicator-style) var(--fe-folder-indicator-color);
      }
    }
  }

  /* Folder Tree */

  &.folder-tree {
    summary + ul {
      padding-inline-start: var(--fe-tree-indent);

      li {
        &:before {
          content: "";
          display: block;
          position: absolute;
          inset: 0;
          width: calc(var(--fe-folder-indent) + var(--fe-tree-width));
          height: calc(var(--fe-line-height) / 2);
          border-style: var(--fe-tree-style);
          border-color: var(--fe-tree-color);
          border-width: 0;
        }

        &:not(:last-of-type) {
          border-inline-start: var(--fe-tree-width) var(--fe-tree-style)
          var(--fe-tree-color);
          &:before {
            border-block-end-width: var(--fe-tree-width);
          }
        }

        &:last-of-type {
          &:before {
            border-inline-start-width: var(--fe-tree-width);
            border-block-end-width: var(--fe-tree-width);
          }
        }
      }
    }
  }

  /* Active, Hover & Focus Structure */

  summary::after,
  li:not(:has(details))::after {
    display: block;
    content: "";
    position: absolute;
    inset: 0;
    height: var(--fe-line-height);
    background-color: transparent;
    z-index: -1;
  }

  /* Active */

  summary.active,
  li.active:not(:has(details)) {
    color: var(--fe-active-text-color);

    &::after {
      background-color: var(--fe-active-bg-color);
      box-shadow: 100px 0 0 0 var(--fe-active-bg-color),
      -100px 0 0 0 var(--fe-active-bg-color);
    }
  }

  /* Hover */

  summary:hover,
  summary:focus,
  li:not(:has(details)):hover,
  li:not(:has(details)):focus {
    color: var(--fe-hover-text-color);

    &::after {
      background-color: var(--fe-hover-bg-color);
      box-shadow: 100px 0 0 0 var(--fe-hover-bg-color),
      -100px 0 0 0 var(--fe-hover-bg-color);
    }
  }
}

body {
  background-color: #000;
  color: #fff;
  display: grid;
  place-items: center;
  margin: 0;
  height: 100vh;
}

body > div {
  width: 300px;
  height: 80vh;
}

.file-explorer.theme-test {
  // --fe-folder-marker-open: "⊕ ";
  // --fe-folder-marker-close: "⊖ ";

  // --fe-tree-indent: 4rem;
  // --fe-folder-indent: 1em;

  --fe-active-bg-color: #555;
  --fe-active-text-color: #ccc;

  --fe-hover-bg-color: #444;
  --fe-hover-text-color: #999;

  // direction: rtl;

  background-color: #333;
  color: #eee;
  padding: 10px 15px;
  resize: vertical;
  resize: both;
}

.file-icons {
  display: inline-block;
  width: 20px;
  height: 20px;
  box-sizing: border-box;
  margin-inline-end: 1ch;
  background: var(--file-icon);
  background-repeat: no-repeat;
  background-size: contain;

  &-none {
    --file-icon: radial-gradient(
        circle at 50% 0,
        rgba(255, 0, 0, 0.5),
        rgba(255, 0, 0, 0) 70.71%
    ),
    radial-gradient(
        circle at 6.7% 75%,
        rgba(0, 0, 255, 0.5),
        rgba(0, 0, 255, 0) 70.71%
    ),
    radial-gradient(
        circle at 93.3% 75%,
        rgba(0, 255, 0, 0.5),
        rgba(0, 255, 0, 0) 70.71%
    )
    beige;
    border-radius: 50%;
  }

  &-folder {
    --file-icon: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHRpdGxlPmRlZmF1bHRfZm9sZGVyPC90aXRsZT48cGF0aCBkPSJNMjcuNSw1LjVIMTguMkwxNi4xLDkuN0g0LjRWMjYuNUgyOS42VjUuNVptMCw0LjJIMTkuM2wxLjEtMi4xaDcuMVoiIHN0eWxlPSJmaWxsOiNjMDk1NTMiLz48L3N2Zz4=");
  }

  &-json {
    --file-icon: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHRpdGxlPmZpbGVfdHlwZV9qc29uPC90aXRsZT48cGF0aCBkPSJNNC4wMTQsMTQuOTc2YTIuNTEsMi41MSwwLDAsMCwxLjU2Ny0uNTE4QTIuMzc3LDIuMzc3LDAsMCwwLDYuMzg2LDEzLjEsMTUuMjYxLDE1LjI2MSwwLDAsMCw2LjYsMTAuMTU2cS4wMTItMi4wODUuMDc1LTIuNzQ3YTUuMjM2LDUuMjM2LDAsMCwxLC40MTgtMS42ODYsMy4wMjUsMy4wMjUsMCwwLDEsLjc1NS0xLjAxOEEzLjA0NiwzLjA0NiwwLDAsMSw5LDQuMTI1LDYuNzYyLDYuNzYyLDAsMCwxLDEwLjU0NCw0aC43VjUuOTZoLS4zODdhMi4zMzgsMi4zMzgsMCwwLDAtMS43MjMuNDY4QTMuNCwzLjQsMCwwLDAsOC43MDksOC41MmEzNi4wNTQsMzYuMDU0LDAsMCwxLS4xMzcsNC4xMzMsNC43MzQsNC43MzQsMCwwLDEtLjc2OCwyLjA2QTQuNTY3LDQuNTY3LDAsMCwxLDYuMSwxNmEzLjgwOSwzLjgwOSwwLDAsMSwxLjk5MiwxLjc1NCw4Ljg2MSw4Ljg2MSwwLDAsMSwuNjE4LDMuODY1cTAsMi40MzUuMDUsMi45QTEuNzU1LDEuNzU1LDAsMCwwLDkuMjY0LDI1LjdhMi42MzksMi42MzksMCwwLDAsMS41OTIuMzM3aC4zODdWMjhoLS43YTUuNjU1LDUuNjU1LDAsMCwxLTEuNzczLS4yLDIuOTcsMi45NywwLDAsMS0xLjMyNC0uOTMsMy4zNTMsMy4zNTMsMCwwLDEtLjY4MS0xLjYzQTI0LjE3NSwyNC4xNzUsMCwwLDEsNi42LDIyLjAwNiwxNi40NjksMTYuNDY5LDAsMCwwLDYuMzg2LDE4LjlhMi40MDgsMi40MDgsMCwwLDAtLjgwNS0xLjM2MSwyLjQ4OSwyLjQ4OSwwLDAsMC0xLjU2Ny0uNTI0WiIgc3R5bGU9ImZpbGw6I2Y1ZGUxOSIvPjxwYXRoIGQ9Ik0yNy45ODYsMTcuMDExYTIuNDg5LDIuNDg5LDAsMCwwLTEuNTY3LjUyNCwyLjQwOCwyLjQwOCwwLDAsMC0uODA1LDEuMzYxLDE2LjQ2OSwxNi40NjksMCwwLDAtLjIxMiwzLjEwOSwyNC4xNzUsMjQuMTc1LDAsMCwxLS4xNjksMy4yMzQsMy4zNTMsMy4zNTMsMCwwLDEtLjY4MSwxLjYzLDIuOTcsMi45NywwLDAsMS0xLjMyNC45Myw1LjY1NSw1LjY1NSwwLDAsMS0xLjc3My4yaC0uN1YyNi4wNGguMzg3YTIuNjM5LDIuNjM5LDAsMCwwLDEuNTkyLS4zMzcsMS43NTUsMS43NTUsMCwwLDAsLjUwNi0xLjE4NnEuMDUtLjQ2Mi4wNS0yLjlhOC44NjEsOC44NjEsMCwwLDEsLjYxOC0zLjg2NUEzLjgwOSwzLjgwOSwwLDAsMSwyNS45LDE2YTQuNTY3LDQuNTY3LDAsMCwxLTEuNy0xLjI4Niw0LjczNCw0LjczNCwwLDAsMS0uNzY4LTIuMDYsMzYuMDU0LDM2LjA1NCwwLDAsMS0uMTM3LTQuMTMzLDMuNCwzLjQsMCwwLDAtLjQyNS0yLjA5MiwyLjMzOCwyLjMzOCwwLDAsMC0xLjcyMy0uNDY4aC0uMzg3VjRoLjdBNi43NjIsNi43NjIsMCwwLDEsMjMsNC4xMjVhMy4wNDYsMy4wNDYsMCwwLDEsMS4xNDkuNTgxLDMuMDI1LDMuMDI1LDAsMCwxLC43NTUsMS4wMTgsNS4yMzYsNS4yMzYsMCwwLDEsLjQxOCwxLjY4NnEuMDYyLjY2Mi4wNzUsMi43NDdhMTUuMjYxLDE1LjI2MSwwLDAsMCwuMjEyLDIuOTQ3LDIuMzc3LDIuMzc3LDAsMCwwLC44MDUsMS4zNTUsMi41MSwyLjUxLDAsMCwwLDEuNTY3LjUxOFoiIHN0eWxlPSJmaWxsOiNmNWRlMTkiLz48L3N2Zz4=");
  }

  &-js {
    --file-icon: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHRpdGxlPmZpbGVfdHlwZV9qczwvdGl0bGU+PHBhdGggZD0iTTE4Ljc3NCwxOS43YTMuNzI3LDMuNzI3LDAsMCwwLDMuMzc2LDIuMDc4YzEuNDE4LDAsMi4zMjQtLjcwOSwyLjMyNC0xLjY4OCwwLTEuMTczLS45MzEtMS41ODktMi40OTEtMi4yNzJsLS44NTYtLjM2N2MtMi40NjktMS4wNTItNC4xMS0yLjM3LTQuMTEtNS4xNTYsMC0yLjU2NywxLjk1Ni00LjUyLDUuMDEyLTQuNTJBNS4wNTgsNS4wNTgsMCwwLDEsMjYuOSwxMC41MmwtMi42NjUsMS43MTFhMi4zMjcsMi4zMjcsMCwwLDAtMi4yLTEuNDY3LDEuNDg5LDEuNDg5LDAsMCwwLTEuNjM4LDEuNDY3YzAsMS4wMjcuNjM2LDEuNDQyLDIuMSwyLjA3OGwuODU2LjM2NmMyLjkwOCwxLjI0Nyw0LjU0OSwyLjUxOCw0LjU0OSw1LjM3NiwwLDMuMDgxLTIuNDIsNC43NjktNS42NzEsNC43NjlhNi41NzUsNi41NzUsMCwwLDEtNi4yMzYtMy41Wk02LjY4NiwyMGMuNTM4Ljk1NCwxLjAyNywxLjc2LDIuMiwxLjc2LDEuMTI0LDAsMS44MzQtLjQ0LDEuODM0LTIuMTVWNy45NzVoMy40MjJWMTkuNjU4YzAsMy41NDMtMi4wNzgsNS4xNTYtNS4xMSw1LjE1NkE1LjMxMiw1LjMxMiwwLDAsMSwzLjksMjEuNjg4WiIgc3R5bGU9ImZpbGw6I2Y1ZGUxOSIvPjwvc3ZnPg==");
  }

  &-css {
    --file-icon: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHRpdGxlPmZpbGVfdHlwZV9jc3M8L3RpdGxlPjxwb2x5Z29uIHBvaW50cz0iNS45MDIgMjcuMjAxIDMuNjU2IDIgMjguMzQ0IDIgMjYuMDk1IDI3LjE5NyAxNS45ODUgMzAgNS45MDIgMjcuMjAxIiBzdHlsZT0iZmlsbDojMTU3MmI2Ii8+PHBvbHlnb24gcG9pbnRzPSIxNiAyNy44NTggMjQuMTcgMjUuNTkzIDI2LjA5MiA0LjA2MSAxNiA0LjA2MSAxNiAyNy44NTgiIHN0eWxlPSJmaWxsOiMzM2E5ZGMiLz48cG9seWdvbiBwb2ludHM9IjE2IDEzLjE5MSAyMC4wOSAxMy4xOTEgMjAuMzcyIDEwLjAyNiAxNiAxMC4wMjYgMTYgNi45MzUgMTYuMDExIDYuOTM1IDIzLjc1IDYuOTM1IDIzLjY3NiA3Ljc2NCAyMi45MTcgMTYuMjgyIDE2IDE2LjI4MiAxNiAxMy4xOTEiIHN0eWxlPSJmaWxsOiNmZmYiLz48cG9seWdvbiBwb2ludHM9IjE2LjAxOSAyMS4yMTggMTYuMDA1IDIxLjIyMiAxMi41NjMgMjAuMjkyIDEyLjM0MyAxNy44MjcgMTAuNjcgMTcuODI3IDkuMjQgMTcuODI3IDkuNjczIDIyLjY4IDE2LjAwNCAyNC40MzggMTYuMDE5IDI0LjQzNCAxNi4wMTkgMjEuMjE4IiBzdHlsZT0iZmlsbDojZWJlYmViIi8+PHBvbHlnb24gcG9pbnRzPSIxOS44MjcgMTYuMTUxIDE5LjQ1NSAyMC4yOSAxNi4wMDggMjEuMjIgMTYuMDA4IDI0LjQzNiAyMi4zNDQgMjIuNjggMjIuMzkxIDIyLjE1OCAyMi45MjggMTYuMTUxIDE5LjgyNyAxNi4xNTEiIHN0eWxlPSJmaWxsOiNmZmYiLz48cG9seWdvbiBwb2ludHM9IjE2LjAxMSA2LjkzNSAxNi4wMTEgOC44NTUgMTYuMDExIDEwLjAxOCAxNi4wMTEgMTAuMDI2IDguNTU1IDEwLjAyNiA4LjU1NSAxMC4wMjYgOC41NDUgMTAuMDI2IDguNDgzIDkuMzMxIDguMzQyIDcuNzY0IDguMjY4IDYuOTM1IDE2LjAxMSA2LjkzNSIgc3R5bGU9ImZpbGw6I2ViZWJlYiIvPjxwb2x5Z29uIHBvaW50cz0iMTYgMTMuMTkxIDE2IDE1LjExMSAxNiAxNi4yNzQgMTYgMTYuMjgyIDEyLjYxMSAxNi4yODIgMTIuNjExIDE2LjI4MiAxMi42MDEgMTYuMjgyIDEyLjUzOSAxNS41ODcgMTIuMzk5IDE0LjAyIDEyLjMyNSAxMy4xOTEgMTYgMTMuMTkxIiBzdHlsZT0iZmlsbDojZWJlYmViIi8+PC9zdmc+");
  }

  &-html {
    --file-icon: url("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMiAzMiI+PHRpdGxlPmZpbGVfdHlwZV9odG1sPC90aXRsZT48cG9seWdvbiBwb2ludHM9IjUuOTAyIDI3LjIwMSAzLjY1NSAyIDI4LjM0NSAyIDI2LjA5NSAyNy4xOTcgMTUuOTg1IDMwIDUuOTAyIDI3LjIwMSIgc3R5bGU9ImZpbGw6I2U0NGYyNiIvPjxwb2x5Z29uIHBvaW50cz0iMTYgMjcuODU4IDI0LjE3IDI1LjU5MyAyNi4wOTIgNC4wNjEgMTYgNC4wNjEgMTYgMjcuODU4IiBzdHlsZT0iZmlsbDojZjE2NjJhIi8+PHBvbHlnb24gcG9pbnRzPSIxNiAxMy40MDcgMTEuOTEgMTMuNDA3IDExLjYyOCAxMC4yNDIgMTYgMTAuMjQyIDE2IDcuMTUxIDE1Ljk4OSA3LjE1MSA4LjI1IDcuMTUxIDguMzI0IDcuOTgxIDkuMDgzIDE2LjQ5OCAxNiAxNi40OTggMTYgMTMuNDA3IiBzdHlsZT0iZmlsbDojZWJlYmViIi8+PHBvbHlnb24gcG9pbnRzPSIxNiAyMS40MzQgMTUuOTg2IDIxLjQzOCAxMi41NDQgMjAuNTA5IDEyLjMyNCAxOC4wNDQgMTAuNjUxIDE4LjA0NCA5LjIyMSAxOC4wNDQgOS42NTQgMjIuODk2IDE1Ljk4NiAyNC42NTQgMTYgMjQuNjUgMTYgMjEuNDM0IiBzdHlsZT0iZmlsbDojZWJlYmViIi8+PHBvbHlnb24gcG9pbnRzPSIxNS45ODkgMTMuNDA3IDE1Ljk4OSAxNi40OTggMTkuNzk1IDE2LjQ5OCAxOS40MzcgMjAuNTA3IDE1Ljk4OSAyMS40MzcgMTUuOTg5IDI0LjY1MyAyMi4zMjYgMjIuODk2IDIyLjM3MiAyMi4zNzQgMjMuMDk4IDE0LjIzNyAyMy4xNzQgMTMuNDA3IDIyLjM0MSAxMy40MDcgMTUuOTg5IDEzLjQwNyIgc3R5bGU9ImZpbGw6I2ZmZiIvPjxwb2x5Z29uIHBvaW50cz0iMTUuOTg5IDcuMTUxIDE1Ljk4OSA5LjA3MSAxNS45ODkgMTAuMjM1IDE1Ljk4OSAxMC4yNDIgMjMuNDQ1IDEwLjI0MiAyMy40NDUgMTAuMjQyIDIzLjQ1NSAxMC4yNDIgMjMuNTE3IDkuNTQ4IDIzLjY1OCA3Ljk4MSAyMy43MzIgNy4xNTEgMTUuOTg5IDcuMTUxIiBzdHlsZT0iZmlsbDojZmZmIi8+PC9zdmc+");
  }

  &-xls {
    --file-icon: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABmJLR0QA/wD/AP+gvaeTAAACU0lEQVRIie2UT0jTYRjHP+9PjV3WyNZBaNGtH82ptdCDHQryluQKWXoPKRI7hYiR/YM6REcTwgpic1E4dZRBsHQe8lLBb8FPo0tdDOdiDHU4treD7dfm/ip08wvP4Xmf532+z/M+z/PCLspAlHM4cr3VbKpJNKYVeVQg7YBTSqa0u58fVEJQna04+h37lKo9dilwgnRKgVOwrkpQRFY+QuH9jipouHFcVnLJUmfBUmcpZl4JuPzWjKJUmsk2sD9bqS7mVQoOaz0n1VY8+hjd6kXjXIuE0SLhHN+CBG32M9hqD+L/NEl0NcqJw04abA4mvwSIxCPUW+10qW48+hhdqvvfRZ3KCOKJOH1tvZhNZh4HR7h34Q5LsSWezj0HwKv7eBObBqDd7ypZbUGCj9/n+aDP4G7uJJFMcMBspfdFH1JuzkCX6uby6R7a/S6mOsaNe17dh0cfK08A8HD6Ea+vvqTn1CW88z4Wf30zbOHIV7y6zwiawdbngRJTVF1VA0BapjHVmIq5lUVBAkUo3Dw3yHJ8mdHQM847O2iwOQx7psmw+VwZcVjr82IVXDR3cycDZ/sZeDVIUJ8hcG2C6GoU93A3qXSq3KIRcPmNuHkVCCEwm8wMB0d4q71jbWONoYnbhBbnOFRrM7LONHeqY9yQ7J3IIK/JUkqezI7mnM0uhJhdCBn6dpq8o03WImF+6D8B8sZyK/7HX7SSreRUIJPJ2vzvGnVrIrGl2K3QleBQJWw5BNp97Tcw91cAaBlq2bueSjYKKZvSiGNC0IRkY5tV7aI4/gAUZ9xSGz9WygAAAABJRU5ErkJggg==");
  }

  &-docx {
    --file-icon: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABmJLR0QA/wD/AP+gvaeTAAAB9klEQVRIie2UPWhTURTHf/c1Bm2NSZ7BasCYJkK+sIk8FEHwoyAiQhctDgUd3ISCu4PazUlc3BQKurg4iKBQnERalJcgxZik1KI2WkxiSoaY2PeuS5WmMealqVv/cIdz7rnnd87l3gObaiPRLsAzfM9Rq2+JY5pRiRITitSQPKk8v3TLCsC22nCefeg2DSMmpNQkaCC1Wk2EQSoIgUCCBCGYXFcHjtMT0sqh3nCE3lCk1XbxwxWH57ehWK2kA+1cbdhaRf1LR7w9nDxkb/JPLxhM5Y0GX1MHQ5qX88f9AAwGVa6OxFCEYO+uPsbORTsupgkQ2efi2sUEAKOngoxf1gh4HRyL7+bCUKB7gJ4p4N/jYKu9By3k4Vv5B/H9KiGfk2Su2D0gNVtCSoj4XUT9Lp5Nf+ZAQCXsc6FnNwBQrS2T/bTEyIkB5vIVXs0sMhh0E/I50bOF7gEAyVyR4aM+UrMlUrkSsQE3/e5tpOfLGwfw9W9HzxR4/7GMs8/Ou/ky9WWzY8Bf/8HkmwVuP5rhRfILhikZn0jytVjtOHlLwFy+wvX7+h/77uP0upK3BLTTVN7g7eu6pdj/MYsa3nJDB4rNpq4d1yDCawupZtI3F+8cvmGF1gBYejr6HXi5sgBQzzzY8dOUcSHNhBQclJBAYu1+NmVFvwBAxaNzhycnSQAAAABJRU5ErkJggg==");
  }
}

</style>