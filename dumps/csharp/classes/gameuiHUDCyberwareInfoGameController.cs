using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDCyberwareInfoGameController : gameuiHUDGameController
	{
		private CName _activatePopupAnimName;
		private CName _deactivatePopupAnimName;
		private CName _activateAnimName;
		private CName _deactivateAnimName;
		private CName _fact;
		private inkWidgetReference _hudElement;
		private CBool _isCyberwareDeactivated;
		private CHandle<inkanimProxy> _popupAnimProxy;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(9)] 
		[RED("activatePopupAnimName")] 
		public CName ActivatePopupAnimName
		{
			get => GetProperty(ref _activatePopupAnimName);
			set => SetProperty(ref _activatePopupAnimName, value);
		}

		[Ordinal(10)] 
		[RED("deactivatePopupAnimName")] 
		public CName DeactivatePopupAnimName
		{
			get => GetProperty(ref _deactivatePopupAnimName);
			set => SetProperty(ref _deactivatePopupAnimName, value);
		}

		[Ordinal(11)] 
		[RED("activateAnimName")] 
		public CName ActivateAnimName
		{
			get => GetProperty(ref _activateAnimName);
			set => SetProperty(ref _activateAnimName, value);
		}

		[Ordinal(12)] 
		[RED("deactivateAnimName")] 
		public CName DeactivateAnimName
		{
			get => GetProperty(ref _deactivateAnimName);
			set => SetProperty(ref _deactivateAnimName, value);
		}

		[Ordinal(13)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(14)] 
		[RED("hudElement")] 
		public inkWidgetReference HudElement
		{
			get => GetProperty(ref _hudElement);
			set => SetProperty(ref _hudElement, value);
		}

		[Ordinal(15)] 
		[RED("isCyberwareDeactivated")] 
		public CBool IsCyberwareDeactivated
		{
			get => GetProperty(ref _isCyberwareDeactivated);
			set => SetProperty(ref _isCyberwareDeactivated, value);
		}

		[Ordinal(16)] 
		[RED("popupAnimProxy")] 
		public CHandle<inkanimProxy> PopupAnimProxy
		{
			get => GetProperty(ref _popupAnimProxy);
			set => SetProperty(ref _popupAnimProxy, value);
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public gameuiHUDCyberwareInfoGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
