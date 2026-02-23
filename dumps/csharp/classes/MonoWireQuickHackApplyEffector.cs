using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MonoWireQuickHackApplyEffector : AbstractApplyQuickhackEffector
	{
		private CBool _hasSpreadWindowBeenOpened;
		private CArray<CHandle<MonowireSpreadableNPC>> _targetsToSpreadQuickhack;
		private CFloat _timeOfPossibleSpread;
		private CFloat _spreadWindowTime;
		private gameDelayID _spreadCallbackID;

		[Ordinal(2)] 
		[RED("hasSpreadWindowBeenOpened")] 
		public CBool HasSpreadWindowBeenOpened
		{
			get => GetProperty(ref _hasSpreadWindowBeenOpened);
			set => SetProperty(ref _hasSpreadWindowBeenOpened, value);
		}

		[Ordinal(3)] 
		[RED("targetsToSpreadQuickhack")] 
		public CArray<CHandle<MonowireSpreadableNPC>> TargetsToSpreadQuickhack
		{
			get => GetProperty(ref _targetsToSpreadQuickhack);
			set => SetProperty(ref _targetsToSpreadQuickhack, value);
		}

		[Ordinal(4)] 
		[RED("timeOfPossibleSpread")] 
		public CFloat TimeOfPossibleSpread
		{
			get => GetProperty(ref _timeOfPossibleSpread);
			set => SetProperty(ref _timeOfPossibleSpread, value);
		}

		[Ordinal(5)] 
		[RED("spreadWindowTime")] 
		public CFloat SpreadWindowTime
		{
			get => GetProperty(ref _spreadWindowTime);
			set => SetProperty(ref _spreadWindowTime, value);
		}

		[Ordinal(6)] 
		[RED("spreadCallbackID")] 
		public gameDelayID SpreadCallbackID
		{
			get => GetProperty(ref _spreadCallbackID);
			set => SetProperty(ref _spreadCallbackID, value);
		}

		public MonoWireQuickHackApplyEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
