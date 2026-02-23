using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrencyNotification : GenericNotificationController
	{
		private CName _currencyUpdateAnimation;
		private inkTextWidgetReference _currencyDiff;
		private inkTextWidgetReference _currencyTotal;
		private wCHandle<inkTextValueProgressAnimationController> _total_animator;
		private CHandle<gameuiCurrencyUpdateNotificationViewData> _currencyData;
		private CHandle<inkanimProxy> _animProxy;
		private CEnum<CurrencyNotificationAnimState> _animState;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CHandle<redCallbackObject> _uiSystemId;

		[Ordinal(16)] 
		[RED("CurrencyUpdateAnimation")] 
		public CName CurrencyUpdateAnimation
		{
			get => GetProperty(ref _currencyUpdateAnimation);
			set => SetProperty(ref _currencyUpdateAnimation, value);
		}

		[Ordinal(17)] 
		[RED("CurrencyDiff")] 
		public inkTextWidgetReference CurrencyDiff
		{
			get => GetProperty(ref _currencyDiff);
			set => SetProperty(ref _currencyDiff, value);
		}

		[Ordinal(18)] 
		[RED("CurrencyTotal")] 
		public inkTextWidgetReference CurrencyTotal
		{
			get => GetProperty(ref _currencyTotal);
			set => SetProperty(ref _currencyTotal, value);
		}

		[Ordinal(19)] 
		[RED("total_animator")] 
		public wCHandle<inkTextValueProgressAnimationController> Total_animator
		{
			get => GetProperty(ref _total_animator);
			set => SetProperty(ref _total_animator, value);
		}

		[Ordinal(20)] 
		[RED("currencyData")] 
		public CHandle<gameuiCurrencyUpdateNotificationViewData> CurrencyData
		{
			get => GetProperty(ref _currencyData);
			set => SetProperty(ref _currencyData, value);
		}

		[Ordinal(21)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(22)] 
		[RED("animState")] 
		public CEnum<CurrencyNotificationAnimState> AnimState
		{
			get => GetProperty(ref _animState);
			set => SetProperty(ref _animState, value);
		}

		[Ordinal(23)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(24)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(25)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		public CurrencyNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
