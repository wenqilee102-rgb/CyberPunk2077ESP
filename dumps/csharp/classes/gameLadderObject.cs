using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLadderObject : gameObject
	{
		private CFloat _heightOfBottomPart;
		private CFloat _exitStepTop;
		private CFloat _verticalStepTop;
		private CFloat _exitStepBottom;
		private CFloat _verticalStepBottom;
		private CFloat _exitStepJump;
		private CFloat _verticalStepJump;
		private CFloat _enterOffset;

		[Ordinal(36)] 
		[RED("heightOfBottomPart")] 
		public CFloat HeightOfBottomPart
		{
			get => GetProperty(ref _heightOfBottomPart);
			set => SetProperty(ref _heightOfBottomPart, value);
		}

		[Ordinal(37)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get => GetProperty(ref _exitStepTop);
			set => SetProperty(ref _exitStepTop, value);
		}

		[Ordinal(38)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get => GetProperty(ref _verticalStepTop);
			set => SetProperty(ref _verticalStepTop, value);
		}

		[Ordinal(39)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get => GetProperty(ref _exitStepBottom);
			set => SetProperty(ref _exitStepBottom, value);
		}

		[Ordinal(40)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get => GetProperty(ref _verticalStepBottom);
			set => SetProperty(ref _verticalStepBottom, value);
		}

		[Ordinal(41)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get => GetProperty(ref _exitStepJump);
			set => SetProperty(ref _exitStepJump, value);
		}

		[Ordinal(42)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get => GetProperty(ref _verticalStepJump);
			set => SetProperty(ref _verticalStepJump, value);
		}

		[Ordinal(43)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get => GetProperty(ref _enterOffset);
			set => SetProperty(ref _enterOffset, value);
		}

		public gameLadderObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
