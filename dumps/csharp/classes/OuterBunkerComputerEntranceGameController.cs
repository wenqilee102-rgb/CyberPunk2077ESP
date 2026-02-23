using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OuterBunkerComputerEntranceGameController : gameuiBaseBunkerComputerGameController
	{
		private CName _harvestIntroAnimName;
		private CName _harvestLoop1AnimName;
		private CName _harvestLoop2AnimName;
		private CName _harvestLoop3AnimName;
		private CName _harvestOutroAnimName;

		[Ordinal(2)] 
		[RED("harvestIntroAnimName")] 
		public CName HarvestIntroAnimName
		{
			get => GetProperty(ref _harvestIntroAnimName);
			set => SetProperty(ref _harvestIntroAnimName, value);
		}

		[Ordinal(3)] 
		[RED("harvestLoop1AnimName")] 
		public CName HarvestLoop1AnimName
		{
			get => GetProperty(ref _harvestLoop1AnimName);
			set => SetProperty(ref _harvestLoop1AnimName, value);
		}

		[Ordinal(4)] 
		[RED("harvestLoop2AnimName")] 
		public CName HarvestLoop2AnimName
		{
			get => GetProperty(ref _harvestLoop2AnimName);
			set => SetProperty(ref _harvestLoop2AnimName, value);
		}

		[Ordinal(5)] 
		[RED("harvestLoop3AnimName")] 
		public CName HarvestLoop3AnimName
		{
			get => GetProperty(ref _harvestLoop3AnimName);
			set => SetProperty(ref _harvestLoop3AnimName, value);
		}

		[Ordinal(6)] 
		[RED("harvestOutroAnimName")] 
		public CName HarvestOutroAnimName
		{
			get => GetProperty(ref _harvestOutroAnimName);
			set => SetProperty(ref _harvestOutroAnimName, value);
		}

		public OuterBunkerComputerEntranceGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
