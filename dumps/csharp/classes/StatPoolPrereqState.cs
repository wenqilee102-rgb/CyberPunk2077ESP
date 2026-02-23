using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolPrereqState : gamePrereqState
	{
		private CHandle<BaseStatPoolPrereqListener> _statPoolListener;
		private CBool _statpoolWasMissing;
		private wCHandle<gameObject> _object;
		private gameStatsObjectID _statsObjID;

		[Ordinal(0)] 
		[RED("statPoolListener")] 
		public CHandle<BaseStatPoolPrereqListener> StatPoolListener
		{
			get => GetProperty(ref _statPoolListener);
			set => SetProperty(ref _statPoolListener, value);
		}

		[Ordinal(1)] 
		[RED("statpoolWasMissing")] 
		public CBool StatpoolWasMissing
		{
			get => GetProperty(ref _statpoolWasMissing);
			set => SetProperty(ref _statpoolWasMissing, value);
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

		public StatPoolPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
