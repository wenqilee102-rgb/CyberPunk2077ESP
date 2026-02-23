using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		private CBool _hasButtonAuthorization;
		private wCHandle<inkTextWidget> _enteredPasswordWidget;
		private wCHandle<inkTextWidget> _passwordStatusWidget;
		private wCHandle<inkWidget> _actionButton;
		private wCHandle<inkTextWidget> _actionText;
		private CArray<CName> _passwordsList;
		private CString _cardName;
		private CBool _isPasswordKnown;
		private CInt32 _maxDigitsCount;
		private wCHandle<inkHorizontalPanelWidget> _row1;
		private wCHandle<inkHorizontalPanelWidget> _row2;
		private wCHandle<inkHorizontalPanelWidget> _row3;
		private wCHandle<inkHorizontalPanelWidget> _row4;
		private CBool _arePasswordsInitialized;
		private wCHandle<gameIBlackboard> _blackboard;

		[Ordinal(10)] 
		[RED("hasButtonAuthorization")] 
		public CBool HasButtonAuthorization
		{
			get => GetProperty(ref _hasButtonAuthorization);
			set => SetProperty(ref _hasButtonAuthorization, value);
		}

		[Ordinal(11)] 
		[RED("enteredPasswordWidget")] 
		public wCHandle<inkTextWidget> EnteredPasswordWidget
		{
			get => GetProperty(ref _enteredPasswordWidget);
			set => SetProperty(ref _enteredPasswordWidget, value);
		}

		[Ordinal(12)] 
		[RED("passwordStatusWidget")] 
		public wCHandle<inkTextWidget> PasswordStatusWidget
		{
			get => GetProperty(ref _passwordStatusWidget);
			set => SetProperty(ref _passwordStatusWidget, value);
		}

		[Ordinal(13)] 
		[RED("actionButton")] 
		public wCHandle<inkWidget> ActionButton
		{
			get => GetProperty(ref _actionButton);
			set => SetProperty(ref _actionButton, value);
		}

		[Ordinal(14)] 
		[RED("ActionText")] 
		public wCHandle<inkTextWidget> ActionText
		{
			get => GetProperty(ref _actionText);
			set => SetProperty(ref _actionText, value);
		}

		[Ordinal(15)] 
		[RED("passwordsList")] 
		public CArray<CName> PasswordsList
		{
			get => GetProperty(ref _passwordsList);
			set => SetProperty(ref _passwordsList, value);
		}

		[Ordinal(16)] 
		[RED("cardName")] 
		public CString CardName
		{
			get => GetProperty(ref _cardName);
			set => SetProperty(ref _cardName, value);
		}

		[Ordinal(17)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get => GetProperty(ref _isPasswordKnown);
			set => SetProperty(ref _isPasswordKnown, value);
		}

		[Ordinal(18)] 
		[RED("maxDigitsCount")] 
		public CInt32 MaxDigitsCount
		{
			get => GetProperty(ref _maxDigitsCount);
			set => SetProperty(ref _maxDigitsCount, value);
		}

		[Ordinal(19)] 
		[RED("row1")] 
		public wCHandle<inkHorizontalPanelWidget> Row1
		{
			get => GetProperty(ref _row1);
			set => SetProperty(ref _row1, value);
		}

		[Ordinal(20)] 
		[RED("row2")] 
		public wCHandle<inkHorizontalPanelWidget> Row2
		{
			get => GetProperty(ref _row2);
			set => SetProperty(ref _row2, value);
		}

		[Ordinal(21)] 
		[RED("row3")] 
		public wCHandle<inkHorizontalPanelWidget> Row3
		{
			get => GetProperty(ref _row3);
			set => SetProperty(ref _row3, value);
		}

		[Ordinal(22)] 
		[RED("row4")] 
		public wCHandle<inkHorizontalPanelWidget> Row4
		{
			get => GetProperty(ref _row4);
			set => SetProperty(ref _row4, value);
		}

		[Ordinal(23)] 
		[RED("arePasswordsInitialized")] 
		public CBool ArePasswordsInitialized
		{
			get => GetProperty(ref _arePasswordsInitialized);
			set => SetProperty(ref _arePasswordsInitialized, value);
		}

		[Ordinal(24)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public KeypadDeviceController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
