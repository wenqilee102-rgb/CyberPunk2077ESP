using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketingConsentPopupController : gameuiWidgetGameController
	{
		private inkWidgetReference _titleOneRef;
		private inkWidgetReference _titleTwoRef;
		private inkWidgetReference _messageIntroOneRef;
		private inkWidgetReference _messageIntroTwoRef;
		private inkWidgetReference _ageConsentRef;
		private inkWidgetReference _qrCodeContainerRef;
		private CBool _questionOne_State;
		private CBool _questionTwo_State;
		private inkWidgetReference _questionOne_ContainerRef;
		private inkWidgetReference _questionTwo_ContainerRef;
		private inkWidgetReference _questionOne_ToggleRef;
		private inkWidgetReference _questionOne_ToggleFillRef;
		private inkWidgetReference _questionTwo_ToggleRef;
		private inkWidgetReference _questionTwo_ToggleFillRef;
		private inkWidgetReference _hyperlinkButtonRef;
		private inkWidgetReference _applyButtonRef;
		private inkWidgetReference _declineButtonRef;
		private inkWidgetReference _aceptAllButtonRef;
		private inkWidgetReference _declineAllButtonRef;
		private CName _introAnimationName;
		private CName _aceptAllAnimationName;
		private CName _declineAllAnimationName;
		private CHandle<MarketingConsentPopupData> _data;
		private CBool _showBothQuestions;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CHandle<inkanimProxy> _confirmationAnimProxy;

		[Ordinal(2)] 
		[RED("titleOneRef")] 
		public inkWidgetReference TitleOneRef
		{
			get => GetProperty(ref _titleOneRef);
			set => SetProperty(ref _titleOneRef, value);
		}

		[Ordinal(3)] 
		[RED("titleTwoRef")] 
		public inkWidgetReference TitleTwoRef
		{
			get => GetProperty(ref _titleTwoRef);
			set => SetProperty(ref _titleTwoRef, value);
		}

		[Ordinal(4)] 
		[RED("messageIntroOneRef")] 
		public inkWidgetReference MessageIntroOneRef
		{
			get => GetProperty(ref _messageIntroOneRef);
			set => SetProperty(ref _messageIntroOneRef, value);
		}

		[Ordinal(5)] 
		[RED("messageIntroTwoRef")] 
		public inkWidgetReference MessageIntroTwoRef
		{
			get => GetProperty(ref _messageIntroTwoRef);
			set => SetProperty(ref _messageIntroTwoRef, value);
		}

		[Ordinal(6)] 
		[RED("ageConsentRef")] 
		public inkWidgetReference AgeConsentRef
		{
			get => GetProperty(ref _ageConsentRef);
			set => SetProperty(ref _ageConsentRef, value);
		}

		[Ordinal(7)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetProperty(ref _qrCodeContainerRef);
			set => SetProperty(ref _qrCodeContainerRef, value);
		}

		[Ordinal(8)] 
		[RED("questionOne_State")] 
		public CBool QuestionOne_State
		{
			get => GetProperty(ref _questionOne_State);
			set => SetProperty(ref _questionOne_State, value);
		}

		[Ordinal(9)] 
		[RED("questionTwo_State")] 
		public CBool QuestionTwo_State
		{
			get => GetProperty(ref _questionTwo_State);
			set => SetProperty(ref _questionTwo_State, value);
		}

		[Ordinal(10)] 
		[RED("questionOne_ContainerRef")] 
		public inkWidgetReference QuestionOne_ContainerRef
		{
			get => GetProperty(ref _questionOne_ContainerRef);
			set => SetProperty(ref _questionOne_ContainerRef, value);
		}

		[Ordinal(11)] 
		[RED("questionTwo_ContainerRef")] 
		public inkWidgetReference QuestionTwo_ContainerRef
		{
			get => GetProperty(ref _questionTwo_ContainerRef);
			set => SetProperty(ref _questionTwo_ContainerRef, value);
		}

		[Ordinal(12)] 
		[RED("questionOne_ToggleRef")] 
		public inkWidgetReference QuestionOne_ToggleRef
		{
			get => GetProperty(ref _questionOne_ToggleRef);
			set => SetProperty(ref _questionOne_ToggleRef, value);
		}

		[Ordinal(13)] 
		[RED("questionOne_ToggleFillRef")] 
		public inkWidgetReference QuestionOne_ToggleFillRef
		{
			get => GetProperty(ref _questionOne_ToggleFillRef);
			set => SetProperty(ref _questionOne_ToggleFillRef, value);
		}

		[Ordinal(14)] 
		[RED("questionTwo_ToggleRef")] 
		public inkWidgetReference QuestionTwo_ToggleRef
		{
			get => GetProperty(ref _questionTwo_ToggleRef);
			set => SetProperty(ref _questionTwo_ToggleRef, value);
		}

		[Ordinal(15)] 
		[RED("questionTwo_ToggleFillRef")] 
		public inkWidgetReference QuestionTwo_ToggleFillRef
		{
			get => GetProperty(ref _questionTwo_ToggleFillRef);
			set => SetProperty(ref _questionTwo_ToggleFillRef, value);
		}

		[Ordinal(16)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetProperty(ref _hyperlinkButtonRef);
			set => SetProperty(ref _hyperlinkButtonRef, value);
		}

		[Ordinal(17)] 
		[RED("applyButtonRef")] 
		public inkWidgetReference ApplyButtonRef
		{
			get => GetProperty(ref _applyButtonRef);
			set => SetProperty(ref _applyButtonRef, value);
		}

		[Ordinal(18)] 
		[RED("declineButtonRef")] 
		public inkWidgetReference DeclineButtonRef
		{
			get => GetProperty(ref _declineButtonRef);
			set => SetProperty(ref _declineButtonRef, value);
		}

		[Ordinal(19)] 
		[RED("aceptAllButtonRef")] 
		public inkWidgetReference AceptAllButtonRef
		{
			get => GetProperty(ref _aceptAllButtonRef);
			set => SetProperty(ref _aceptAllButtonRef, value);
		}

		[Ordinal(20)] 
		[RED("declineAllButtonRef")] 
		public inkWidgetReference DeclineAllButtonRef
		{
			get => GetProperty(ref _declineAllButtonRef);
			set => SetProperty(ref _declineAllButtonRef, value);
		}

		[Ordinal(21)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(22)] 
		[RED("aceptAllAnimationName")] 
		public CName AceptAllAnimationName
		{
			get => GetProperty(ref _aceptAllAnimationName);
			set => SetProperty(ref _aceptAllAnimationName, value);
		}

		[Ordinal(23)] 
		[RED("declineAllAnimationName")] 
		public CName DeclineAllAnimationName
		{
			get => GetProperty(ref _declineAllAnimationName);
			set => SetProperty(ref _declineAllAnimationName, value);
		}

		[Ordinal(24)] 
		[RED("data")] 
		public CHandle<MarketingConsentPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(25)] 
		[RED("showBothQuestions")] 
		public CBool ShowBothQuestions
		{
			get => GetProperty(ref _showBothQuestions);
			set => SetProperty(ref _showBothQuestions, value);
		}

		[Ordinal(26)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(27)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("confirmationAnimProxy")] 
		public CHandle<inkanimProxy> ConfirmationAnimProxy
		{
			get => GetProperty(ref _confirmationAnimProxy);
			set => SetProperty(ref _confirmationAnimProxy, value);
		}

		public MarketingConsentPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
