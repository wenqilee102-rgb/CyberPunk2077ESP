using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransmogMessageDescTooltip : MessageTooltip
	{
		private inkWidgetReference _titleWrapper;
		private inkWidgetReference _descriptionWrapper;
		private inkWidgetReference _descriptionLine;
		private inkImageWidgetReference _icon;

		[Ordinal(5)] 
		[RED("titleWrapper")] 
		public inkWidgetReference TitleWrapper
		{
			get => GetProperty(ref _titleWrapper);
			set => SetProperty(ref _titleWrapper, value);
		}

		[Ordinal(6)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(7)] 
		[RED("descriptionLine")] 
		public inkWidgetReference DescriptionLine
		{
			get => GetProperty(ref _descriptionLine);
			set => SetProperty(ref _descriptionLine, value);
		}

		[Ordinal(8)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		public TransmogMessageDescTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
