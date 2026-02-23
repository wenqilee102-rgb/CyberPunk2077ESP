using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexImageButton : CodexListItemController
	{
		private inkImageWidgetReference _image;
		private inkImageWidgetReference _border;
		private inkWidgetReference _translateOnSelect;
		private CFloat _selectTranslationX;

		[Ordinal(22)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(23)] 
		[RED("border")] 
		public inkImageWidgetReference Border
		{
			get => GetProperty(ref _border);
			set => SetProperty(ref _border, value);
		}

		[Ordinal(24)] 
		[RED("translateOnSelect")] 
		public inkWidgetReference TranslateOnSelect
		{
			get => GetProperty(ref _translateOnSelect);
			set => SetProperty(ref _translateOnSelect, value);
		}

		[Ordinal(25)] 
		[RED("selectTranslationX")] 
		public CFloat SelectTranslationX
		{
			get => GetProperty(ref _selectTranslationX);
			set => SetProperty(ref _selectTranslationX, value);
		}

		public CodexImageButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
