using Kotortool_Legacy.API.AuroraParsers;
using Kotortool_Legacy.API.AuroraParsers.Biff;
using Kotortool_Legacy.API.AuroraParsers.Chitin;
using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure.View.MainForm;
using MediatR;

namespace Kotortool_Legacy.Infrastructure.TreeView.CQRS.Commands;

public sealed class BuildTreeViewFromProjectCommand : IRequest<MainForm>
{
    public Project Project { get; set; }

    public MainForm MainFormInstance { get; set; }
}

public sealed class BuildTreeViewCommandHandler : AppRequestHandler<BuildTreeViewFromProjectCommand, MainForm>
{
    protected override Task<MainForm> HandleNext(BuildTreeViewFromProjectCommand request,
        CancellationToken cancellationToken)
    {
        try
        {
            var biffRootNode = Resolve<GenericNode>();
            biffRootNode.Text = "BIFF Resources";
            // node1.FilePath = /*CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\data";*/ string.Empty;


            /*var node1 = new KotorTreeNode("BIFs")
        {
            Tag = "BIFF_Root",
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\data"
        };*/

            var node2 = Resolve<GenericNode>();
            node2.Tag = "dummy";
            biffRootNode.AddRange(node2);
            request.MainFormInstance.TreeView.Nodes.Add(biffRootNode);

            // var rootNode = node1.DispatchQuery<EnhancedTreeNode>(node => node.Where(x => x.Name == "Biff"));

            var rootRimNode = Resolve<RimNode>();
            rootRimNode.Text = "RIM Resources";
            rootRimNode.Tag = "RIM_Root";
            /*node3.AddMetaData(
            ("FilePath", CurrentSettings.KotorLocation(request.MainFormInstance.TreeView.Nodes.IndexOf(node1)) +
                "\\Modules")
        );*/
            rootRimNode.AddMetaData(("FilePath", string.Empty));

            // node3.node3.FilePath = CurrentSettings.KotorLocation(request.MainFormInstance.TreeView.Nodes.IndexOf(node1)) +
            // "\\Modules";
            /*var node3 = new KotorTreeNode("RIMs")
        {
            Tag = "RIM_Root",
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Modules"
        };*/
            var rimsModuleNode = Resolve<GenericNode>();
            rimsModuleNode.Text = "Modules";
            rimsModuleNode.Tag = "RIM_Modules";

            var node5 = Resolve<GenericNode>();
            node5.Text = string.Empty;
            node5.Tag = "dummy";

            rimsModuleNode.AddRange(node5);
            rootRimNode.AddRange(rimsModuleNode);


            var rimNode = Resolve<GenericNode>();
            rimNode.Text = "Rim Resources";
            rimNode.Tag = "RIM_Rims";

            var node7 = Resolve<GenericNode>();
            node7.Text = string.Empty;
            node7.Tag = "dummy";


            rimNode.AddRange(node7);
            rootRimNode.AddRange(rimNode);
            request.MainFormInstance.TreeView.Nodes.Add(rimNode);

            var node8 = Resolve<GenericNode>();
            node8.Text = "ERF Resources";
            node8.Tag = "ERF_Root";
            node8.AddMetaData(("FilePath", string.Empty));

            var node9 = Resolve<GenericNode>();
            node9.Text = "TexturePacks";
            node9.Tag = "ERF_TexturePacks";

            var node10 = Resolve<GenericNode>();
            node10.Text = string.Empty;
            node10.Tag = "dummy";
            node9.AddRange(node10);
            node8.AddRange(node9);

            request.MainFormInstance.TreeView.Nodes.Add(node8);

            var modulesErfNode = Resolve<GenericNode>();
            modulesErfNode.Text = "Modules";
            modulesErfNode.Tag = "ERF_Modules";

            var node12 = Resolve<GenericNode>();
            node12.Text = string.Empty;
            node12.Tag = "dummy";
            modulesErfNode.AddRange(node12);
            node8.AddRange(modulesErfNode);

            var node13 = Resolve<GenericNode>();
            node13.Text = "Saves";
            node13.Tag = "Saves_Root";
            node13.AddMetaData(("FilePath", string.Empty));
            /*var node13 = new KotorTreeNode("Saves")
        {
            Tag = "Saves_Root",
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Saves"
        };*/
            var node14 = Resolve<GenericNode>();
            node14.Text = string.Empty;
            node14.Tag = "dummy";

            node13.AddRange(node14);
            request.MainFormInstance.TreeView.Nodes.Add(node13);

            foreach (var item in request.MainFormInstance.TreeView.Nodes.Cast<EnhancedTreeNode>())
            {
                item.DispatchCommand(x => { x.Expand(); });
            }


            var keyObject = new KeyObject(new AuroraFile(request.Project.FilePath + "/chitin.key"));

            keyObject.Read();

            var bifDataFolderPath = new DirectoryInfo(request.Project.FilePath + "/data");

            var bifPaths = bifDataFolderPath
                .GetFiles()
                .Where(x => x.Name.Contains(".bif"))
                .Select(x => x.FullName)
                .ToList();

            var biffEntries = new List<BiffObject>();

            foreach (var path in bifPaths)
            {
                biffEntries.Add(new BiffObject(new AuroraFile(path)));
            }

            foreach (var biffEntry in biffEntries)
            {
                biffEntry.Read();
                var biffNode = Resolve<GenericNode>();
                biffNode.Text = biffEntry.GetFilename();
                biffNode.Tag = "BIFF";
                biffNode.AddMetaData(("FileName", biffEntry.GetFilename()));
                biffNode.NodeFont = new Font("Arial", 9, FontStyle.Bold);

                var toolStripMenuItem = new ToolStripMenuItem("Extract Actions");
                toolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Extract All"));
                toolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Extract on Criteria"));
                toolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Extract on Type"));
                toolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Extract on ResRef"));
                toolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Extract to Project Folder"));
                var ToolStripMenuItem2 = new ToolStripMenuItem("Extract All");
                var menyItem3 = new ToolStripMenuItem("Open in Biff Editor");

                toolStripMenuItem.Click += (sender, args) =>
                {
                    /*var rim = new RIMObject(new AuroraFile(file));
                    rim.Read();*/
                    var saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = "Biff";
                    if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                    var bytes = new[] { (byte)0 };
                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                };
                
                //biffNode.ContextMenuStrip.Items.AddRange(new ToolStripItemCollection() { toolStripMenuItem, ToolStripMenuItem2, menyItem3 });

                foreach (var resource in biffEntry.GetResources())
                {
                    var resourceNode = Resolve<GenericNode>();
                    resourceNode.Text = "--" + resource.ID;
                    resourceNode.AddMetaData(("Offset", resource.Offset.ToString()));
                    biffNode.AddRange(resourceNode);
                }


                biffRootNode.AddRange(biffNode);
            }
            /*var ToolStripMenuItem = new ToolStripMenuItem("Extract");

            ToolStripMenuItem.Click += (sender, args) =>
            {
                var rim = new RIMObject(new AuroraFile(file));
                rim.Read();
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = file;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var bytes = rim.getRawResource(rim.);
                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                }
            };
            innerRimNode.ContextMenu.ToolStripMenuItems.AddRange(new ToolStripMenuItem[] {new ToolStripMenuItem("Extract")
                {

                }
            });*/

            var rims = new DirectoryInfo(request.Project.FilePath + "/rims");

            var rimFiles = rims.GetFiles()
                .Where(x => x.Name.Contains(".rim"))
                .Select(x => x.FullName)
                .ToList();

            foreach (var file in rimFiles)
            {
                var innerRimNode = Resolve<GenericNode>();
                innerRimNode.Text = file;
                innerRimNode.Tag = "RIM";
                rimNode.AddRange(innerRimNode);
                rimNode.AddMetaData(("FilePath", file));

                innerRimNode.NodeFont = new Font("Arial", 13, FontStyle.Bold);

                var rim = new RimObject(new AuroraFile(file));
                rim.Read();

                foreach (var key in rim.Keys)
                {
                    var keyNode = Resolve<GenericNode>();
                    keyNode.Text = key.ResRef.ToString();
                    keyNode.Tag = "rimKey";
                    keyNode.NodeFont = new Font("Arial", 10, FontStyle.Regular);
                    innerRimNode.AddRange(keyNode);
                }
            }

            var moduleRims = new DirectoryInfo(request.Project.FilePath + "/modules");

            var moduleRimPaths = moduleRims.GetFiles()
                .Where(x => x.Name.Contains(".rim"))
                .Select(x => x.FullName)
                .ToList();

            foreach (var file in moduleRimPaths)
            {
                var innerRimNode = Resolve<GenericNode>();
                innerRimNode.Text = file;
                innerRimNode.Tag = "RIM";
                innerRimNode.AddMetaData(("FilePath", file));

                innerRimNode.NodeFont = new Font("Arial", 12, FontStyle.Bold);
                rimsModuleNode.AddRange(innerRimNode);

                var rim = new RimObject(new AuroraFile(file));
                rim.Read();

                foreach (var key in rim.Keys)
                {
                    var keyNode = Resolve<GenericNode>();
                    keyNode.Text = key.ResRef.ToString();
                    keyNode.Tag = "rimKey";
                    innerRimNode.AddRange(keyNode);
                }
            }


            // TODO: Fix this
            /*CreateTemplateTagsHashFiles();
        ExtractNwScripts();*/

            /*if (_cmdArgs != null)
            _gCmdLineOpenedForm = OpenFileFromCmdLine();*/

            //ManageMruMainFileMenu();
            /*if (CurrentSettings.bRememberLastTreeNode && CurrentSettings.LastClickedTVNodePath != null &&
                                    StringType.StrCmp(CurrentSettings.LastClickedTVNodePath, "", false) != 0)
                                    OpenTreeViewToPath(CurrentSettings.LastClickedTVNodePath, TreeView.Nodes[0], 0);*/
            /*if (_options.bRememberTreeViewState)

*/
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return Task.FromResult(request.MainFormInstance);
    }
}