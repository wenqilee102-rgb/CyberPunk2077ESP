using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityHealthBarGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _healthControllerRef;
		private inkTextWidgetReference _healthPercentageRef;
		private gameEntityReference _targetEntityRef;
		private CHandle<EntityHealthStatListener> _healthStatListener;
		private wCHandle<NameplateBarLogicController> _healthController;
		private ScriptGameInstance _gameInstance;
		private entEntityID _targetEntityID;

		[Ordinal(2)] 
		[RED("healthControllerRef")] 
		public inkWidgetReference HealthControllerRef
		{
			get => GetProperty(ref _healthControllerRef);
			set => SetProperty(ref _healthControllerRef, value);
		}

		[Ordinal(3)] 
		[RED("healthPercentageRef")] 
		public inkTextWidgetReference HealthPercentageRef
		{
			get => GetProperty(ref _healthPercentageRef);
			set => SetProperty(ref _healthPercentageRef, value);
		}

		[Ordinal(4)] 
		[RED("targetEntityRef")] 
		public gameEntityReference TargetEntityRef
		{
			get => GetProperty(ref _targetEntityRef);
			set => SetProperty(ref _targetEntityRef, value);
		}

		[Ordinal(5)] 
		[RED("healthStatListener")] 
		public CHandle<EntityHealthStatListener> HealthStatListener
		{
			get => GetProperty(ref _healthStatListener);
			set => SetProperty(ref _healthStatListener, value);
		}

		[Ordinal(6)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(8)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetProperty(ref _targetEntityID);
			set => SetProperty(ref _targetEntityID, value);
		}

		public EntityHealthBarGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
