namespace CSharpToolsAndTechnique.EventExplanation;

public class ButtonMaster
{
    public event EventHandler<ButtonPressedEventArgs>? ButtonPressed;

    public void onButtonPressed(char KeyCode)
    {
        ButtonPressed?.Invoke(this, new ButtonPressedEventArgs(KeyCode));
    }
}

public class ButtonMasterImplementation
{
    public void Implementation()
    {
        var buttonMaster = new ButtonMaster();

        buttonMaster.ButtonPressed += (sender, eventArgs) =>
        {
            Console.WriteLine($"Button {eventArgs.keyCode}was Pressed.");
        };

        buttonMaster.ButtonPressed += (sender, eventArgs) =>
        {
            Console.WriteLine($"Button {eventArgs.keyCode}was Pressed with different handler.");
        };



        var KeyCode = Console.ReadKey(true).KeyChar;

        buttonMaster.onButtonPressed(KeyCode);
    }
}

public  class ButtonPressedEventArgs
{
    public char keyCode;

    public ButtonPressedEventArgs(char KeyCode)
    {
        keyCode = KeyCode;
    }
}
