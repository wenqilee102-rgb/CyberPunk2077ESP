using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkScreenTierInfo : CVariable
	{
		private inkWidgetReference _wrapper;
		private inkTextWidgetReference _requirementText;
		private inkWidgetReference _attributeLevelWrapper;
		private inkWidgetReference _highlightWidget;
		private CBool _unlocked;
		private CBool _hovered;

		[Ordinal(0)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(1)] 
		[RED("requirementText")] 
		public inkTextWidgetReference RequirementText
		{
			get => GetProperty(ref _requirementText);
			set => SetProperty(ref _requirementText, value);
		}

		[Ordinal(2)] 
		[RED("attributeLevelWrapper")] 
		public inkWidgetReference AttributeLevelWrapper
		{
			get => GetProperty(ref _attributeLevelWrapper);
			set => SetProperty(ref _attributeLevelWrapper, value);
		}

		[Ordinal(3)] 
		[RED("highlightWidget")] 
		public inkWidgetReference HighlightWidget
		{
			get => GetProperty(ref _highlightWidget);
			set => SetProperty(ref _highlightWidget, value);
		}

		[Ordinal(4)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		public PerkScreenTierInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
