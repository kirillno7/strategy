using System.Threading;
public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
    public CancellationTokenSource CancellationTokenSource { get; set; }
    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        CancellationTokenSource?.Cancel();
    }
}