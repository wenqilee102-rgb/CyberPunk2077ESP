using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConsumableChargesPrereqState : gamePrereqState
	{
		private wCHandle<PlayerPuppet> _owner;
		private CHandle<ConsumableChargesPrereqListener> _statPoolListener;
		private wCHandle<gameObject> _object;
		private gameStatsObjectID _statsObjID;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<PlayerPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("statPoolListener")] 
		public CHandle<ConsumableChargesPrereqListener> StatPoolListener
		{
			get => GetProperty(ref _statPoolListener);
			set => SetProperty(ref _statPoolListener, value);
		}

		[Ordinal(2)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(3)] 
		[RED("statsObjID")] 
		public gameStatsObjectID StatsObjID
		{
			get => GetProperty(ref _statsObjID);
			set => SetProperty(ref _statsObjID, value);
		}

		public ConsumableChargesPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
