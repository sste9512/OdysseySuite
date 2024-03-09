
namespace Kotortool_Legacy;

public class utilWindowRelativePositioner
{
    private Form pForm;
    private Form cForm;

    public utilWindowRelativePositioner()
    {
    }

    public utilWindowRelativePositioner(Form parentForm, Form childForm)
    {
        pForm = parentForm;
        cForm = childForm;
    }

    public override bool Equals(object? obj)
    {
        return obj is utilWindowRelativePositioner positioner &&
               EqualityComparer<Form>.Default.Equals(pForm, positioner.pForm) &&
               EqualityComparer<Form>.Default.Equals(cForm, positioner.cForm);
    }

    public Point GetConcentric()
    {
        var concentric = new Point();
        var size = cForm.Size;
        var screen = pForm.RectangleToScreen(pForm.ClientRectangle);
        var workingArea = Screen.GetWorkingArea(pForm);
        concentric.X = checked((int)Math.Round(checked(screen.Left + screen.Right - size.Width) / 2.0));
        if (concentric.X < workingArea.X)
            concentric.X = workingArea.X;
        else if (checked(concentric.X + size.Width) > checked(workingArea.X + workingArea.Width))
            concentric.X = checked(workingArea.X + workingArea.Width - size.Width);
        concentric.Y = checked((int)Math.Round(checked(screen.Top + screen.Bottom - size.Height) / 2.0));
        if (concentric.Y < workingArea.Y)
            concentric.Y = workingArea.Y;
        else if (checked(concentric.Y + size.Height) > checked(workingArea.Y + workingArea.Height))
            concentric.Y = checked(workingArea.Y + workingArea.Height - size.Height);
        return concentric;
    }

    public void SetLocationConcentric() => ((Control)cForm).Location = GetConcentric();
}