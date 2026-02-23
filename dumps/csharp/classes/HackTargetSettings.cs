using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackTargetSettings : CVariable
	{
		private CBool _showDirectionalIndicator;
		private CBool _isRevealPositionAction;
		private CBool _skipBeingHackedSetUp;
		private HUDProgressBarData _hUDData;

		[Ordinal(0)] 
		[RED("showDirectionalIndicator")] 
		public CBool ShowDirectionalIndicator
		{
			get => GetProperty(ref _showDirectionalIndicator);
			set => SetProperty(ref _showDirectionalIndicator, value);
		}

		[Ordinal(1)] 
		[RED("isRevealPositionAction")] 
		public CBool IsRevealPositionAction
		{
			get => GetProperty(ref _isRevealPositionAction);
			set => SetProperty(ref _isRevealPositionAction, value);
		}

		[Ordinal(2)] 
		[RED("skipBeingHackedSetUp")] 
		public CBool SkipBeingHackedSetUp
		{
			get => GetProperty(ref _skipBeingHackedSetUp);
			set => SetProperty(ref _skipBeingHackedSetUp, value);
		}

		[Ordinal(3)] 
		[RED("HUDData")] 
		public HUDProgressBarData HUDData
		{
			get => GetProperty(ref _hUDData);
			set => SetProperty(ref _hUDData, value);
		}

		public HackTargetSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
