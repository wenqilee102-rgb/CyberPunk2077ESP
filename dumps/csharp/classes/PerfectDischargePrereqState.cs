using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerfectDischargePrereqState : StatPoolPrereqState
	{
		private wCHandle<gameObject> _owner;
		private CHandle<PerfectDischargePrereqListener> _perfectDischargeListener;
		private CBool _wasPerfectlyCharged;

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("perfectDischargeListener")] 
		public CHandle<PerfectDischargePrereqListener> PerfectDischargeListener
		{
			get => GetProperty(ref _perfectDischargeListener);
			set => SetProperty(ref _perfectDischargeListener, value);
		}

		[Ordinal(6)] 
		[RED("wasPerfectlyCharged")] 
		public CBool WasPerfectlyCharged
		{
			get => GetProperty(ref _wasPerfectlyCharged);
			set => SetProperty(ref _wasPerfectlyCharged, value);
		}

		public PerfectDischargePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
