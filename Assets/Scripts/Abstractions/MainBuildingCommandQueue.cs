using UnityEngine;
using Zenject;
public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
{
    public ICommand CurrentCommand => default;
    [Inject]
    CommandExecutorBase<IProduceUnitCommand>

    _produceUnitCommandExecutor;

    [Inject]
    CommandExecutorBase<ISetRallyPointCommand>

    _setrally;
    public void Clear() { }
    public async void EnqueueCommand(object command)
    {
        await _produceUnitCommandExecutor.TryExecuteCommand(command);
        await _setrally.TryExecuteCommand(command);
    }
}
