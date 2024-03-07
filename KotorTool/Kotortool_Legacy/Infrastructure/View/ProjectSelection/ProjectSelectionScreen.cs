using Autofac;
using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure.View.MainForm;


namespace Kotortool_Legacy.Infrastructure.View.ProjectSelection;

public partial class ProjectSelectionScreen : Form, IApplicationCache
{
    ComponentActions ComponentActions { get; set; } = new ComponentActions();


    public ProjectSelectionScreen()
    {
        InitializeComponent();


        using (var scope = ComponentActions.ResolveScoped())
        {
            var store = scope.Resolve<IDocumentStore>();
            var projects = store.Projects.FindAll();

            foreach (var project in projects)
            {
                projectListingBox.Items.Add(project.Name);
            }
        }


        projectListingBox.Click += (sender, e) =>
        {
           
            using var scope = ComponentActions.ResolveScoped();
            var store = scope.Resolve<IDocumentStore>();
            var project = store.Projects.FindOne((x => x.Name == projectListingBox.SelectedItem.ToString()));
            var mainForm = ComponentActions.Resolve<MainForm.MainForm>();
            mainForm.Project = project;
            mainForm.Text = "Project : " + project.Name;
            mainForm.Show();
        };
    }

    // Open Folder Dialog
    private void button1_Click(object sender, EventArgs e)
    {
        var dialog = new FolderBrowserDialog();
        dialog.ShowDialog(this);
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            gameFilePathTextBox.Text = dialog.SelectedPath;
        }
    }

    //Create Button
    private void button2_Click(object sender, EventArgs e)
    {
        var projectName = textBox2.Text.Trim();

        if (string.IsNullOrEmpty(projectName))
        {
            MessageBox.Show("Please enter a project name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var gameFilePath = gameFilePathTextBox.Text.Trim();

        if (string.IsNullOrEmpty(gameFilePath))
        {
            MessageBox.Show("Please enter a Game File Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            var store = ComponentActions.Resolve<IDocumentStore>();

            var project = new Project
            {
                Id = Guid.NewGuid(),
                FilePath = gameFilePath,
                UserId = Guid.Empty.ToString(),
                Name = projectName
            };

            var projects = store.Projects.Insert(project);

            var mainForm = ComponentActions.Resolve<MainForm.MainForm>();

            mainForm.Project = project;

            mainForm.Show();
        }
        catch (AggregateException exception)
        {
            string exceptionMessage = string.Empty;

            foreach (var item in exception.InnerExceptions)
            {
                exceptionMessage += item.Message + Environment.NewLine;
            }

            //_logger.LogError(exception, exceptionMessage);

            MessageBox.Show(exceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Cancel
    private void button3_Click(object sender, EventArgs e)
    {
    }

    public bool TryAdd<T>(string key, T value)
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue<T>(string key, out T value)
    {
        throw new NotImplementedException();
    }
}