using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NanoTechPlatesEffector : ModifyAttackEffector
	{
		private CFloat _chanceToTrigger;
		private CFloat _chanceIncrement;
		private CInt32 _nanoPlatesStacks;
		private CFloat _timeWindow;
		private CFloat _minTimeBetweenBlocks;
		private CArray<CFloat> _timeStamps;

		[Ordinal(0)] 
		[RED("chanceToTrigger")] 
		public CFloat ChanceToTrigger
		{
			get => GetProperty(ref _chanceToTrigger);
			set => SetProperty(ref _chanceToTrigger, value);
		}

		[Ordinal(1)] 
		[RED("chanceIncrement")] 
		public CFloat ChanceIncrement
		{
			get => GetProperty(ref _chanceIncrement);
			set => SetProperty(ref _chanceIncrement, value);
		}

		[Ordinal(2)] 
		[RED("nanoPlatesStacks")] 
		public CInt32 NanoPlatesStacks
		{
			get => GetProperty(ref _nanoPlatesStacks);
			set => SetProperty(ref _nanoPlatesStacks, value);
		}

		[Ordinal(3)] 
		[RED("timeWindow")] 
		public CFloat TimeWindow
		{
			get => GetProperty(ref _timeWindow);
			set => SetProperty(ref _timeWindow, value);
		}

		[Ordinal(4)] 
		[RED("minTimeBetweenBlocks")] 
		public CFloat MinTimeBetweenBlocks
		{
			get => GetProperty(ref _minTimeBetweenBlocks);
			set => SetProperty(ref _minTimeBetweenBlocks, value);
		}

		[Ordinal(5)] 
		[RED("timeStamps")] 
		public CArray<CFloat> TimeStamps
		{
			get => GetProperty(ref _timeStamps);
			set => SetProperty(ref _timeStamps, value);
		}

		public NanoTechPlatesEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
