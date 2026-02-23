using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		private inkWidgetReference _stadiaControllerPage;
		private inkWidgetReference _nintendoControllerPage;
		private inkWidgetReference _durangoControllerPage;
		private inkWidgetReference _orbisControllerPage;
		private inkWidgetReference _disclaimerText;
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;

		[Ordinal(3)] 
		[RED("stadiaControllerPage")] 
		public inkWidgetReference StadiaControllerPage
		{
			get => GetProperty(ref _stadiaControllerPage);
			set => SetProperty(ref _stadiaControllerPage, value);
		}

		[Ordinal(4)] 
		[RED("nintendoControllerPage")] 
		public inkWidgetReference NintendoControllerPage
		{
			get => GetProperty(ref _nintendoControllerPage);
			set => SetProperty(ref _nintendoControllerPage, value);
		}

		[Ordinal(5)] 
		[RED("durangoControllerPage")] 
		public inkWidgetReference DurangoControllerPage
		{
			get => GetProperty(ref _durangoControllerPage);
			set => SetProperty(ref _durangoControllerPage, value);
		}

		[Ordinal(6)] 
		[RED("orbisControllerPage")] 
		public inkWidgetReference OrbisControllerPage
		{
			get => GetProperty(ref _orbisControllerPage);
			set => SetProperty(ref _orbisControllerPage, value);
		}

		[Ordinal(7)] 
		[RED("disclaimerText")] 
		public inkWidgetReference DisclaimerText
		{
			get => GetProperty(ref _disclaimerText);
			set => SetProperty(ref _disclaimerText, value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		public gameuiStadiaControllersGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
