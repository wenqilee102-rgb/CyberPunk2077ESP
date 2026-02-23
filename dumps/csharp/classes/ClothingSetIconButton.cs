using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClothingSetIconButton : BaseButtonView
	{
		private inkImageWidgetReference _setIcon;
		private inkWidgetReference _currentIconFrame;
		private TweakDBID _iconID;

		[Ordinal(5)] 
		[RED("setIcon")] 
		public inkImageWidgetReference SetIcon
		{
			get => GetProperty(ref _setIcon);
			set => SetProperty(ref _setIcon, value);
		}

		[Ordinal(6)] 
		[RED("currentIconFrame")] 
		public inkWidgetReference CurrentIconFrame
		{
			get => GetProperty(ref _currentIconFrame);
			set => SetProperty(ref _currentIconFrame, value);
		}

		[Ordinal(7)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		public ClothingSetIconButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
