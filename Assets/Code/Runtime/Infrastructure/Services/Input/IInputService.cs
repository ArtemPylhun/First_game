namespace Code.Runtime.Infrastructure.Services.Input
{
    public interface IInputService
    {
        void Enabled();
        void Disable();
        float GetMovement();
    }
}