using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkTooltipDescriptionEntry : CVariable
	{
		private inkWidgetReference _wrapper;
		private inkTextWidgetReference _level;
		private inkTextWidgetReference _text;
		private inkWidgetReference _videoLabel;
		private inkWidgetReference _highlightLabel;

		[Ordinal(0)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("videoLabel")] 
		public inkWidgetReference VideoLabel
		{
			get => GetProperty(ref _videoLabel);
			set => SetProperty(ref _videoLabel, value);
		}

		[Ordinal(4)] 
		[RED("highlightLabel")] 
		public inkWidgetReference HighlightLabel
		{
			get => GetProperty(ref _highlightLabel);
			set => SetProperty(ref _highlightLabel, value);
		}

		public PerkTooltipDescriptionEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
