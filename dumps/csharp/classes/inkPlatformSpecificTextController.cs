using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		private CName _textLocKey;
		private CName _textLocKey_PS4;
		private CName _textLocKey_Prospero;
		private CName _textLocKey_XB1;
		private CName _textLocKey_Scarlett;

		[Ordinal(1)] 
		[RED("textLocKey")] 
		public CName TextLocKey
		{
			get => GetProperty(ref _textLocKey);
			set => SetProperty(ref _textLocKey, value);
		}

		[Ordinal(2)] 
		[RED("textLocKey_PS4")] 
		public CName TextLocKey_PS4
		{
			get => GetProperty(ref _textLocKey_PS4);
			set => SetProperty(ref _textLocKey_PS4, value);
		}

		[Ordinal(3)] 
		[RED("textLocKey_Prospero")] 
		public CName TextLocKey_Prospero
		{
			get => GetProperty(ref _textLocKey_Prospero);
			set => SetProperty(ref _textLocKey_Prospero, value);
		}

		[Ordinal(4)] 
		[RED("textLocKey_XB1")] 
		public CName TextLocKey_XB1
		{
			get => GetProperty(ref _textLocKey_XB1);
			set => SetProperty(ref _textLocKey_XB1, value);
		}

		[Ordinal(5)] 
		[RED("textLocKey_Scarlett")] 
		public CName TextLocKey_Scarlett
		{
			get => GetProperty(ref _textLocKey_Scarlett);
			set => SetProperty(ref _textLocKey_Scarlett, value);
		}

		public inkPlatformSpecificTextController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
