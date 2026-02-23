using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryPopup : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _messageText;

		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(2)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		public GalleryPopup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
