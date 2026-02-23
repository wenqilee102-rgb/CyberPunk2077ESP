using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransferSaveSystemNotificationLogicController : inkGenericSystemNotificationLogicController
	{
		private inkWidgetReference _contentBlock;
		private inkWidgetReference _spinnerBlock;
		private inkWidgetReference _errorBlock;
		private inkWidgetReference _saveImageContainer;
		private inkImageWidgetReference _saveImage;
		private inkWidgetReference _saveImageEmpty;
		private inkWidgetReference _saveImageSpinner;
		private inkTextWidgetReference _messageText;
		private inkTextWidgetReference _spinnerText;
		private inkTextWidgetReference _errorText;
		private inkWidgetReference _proceedButtonWidget;
		private inkWidgetReference _cancelButtonWidget;
		private wCHandle<inkISystemRequestsHandler> _systemRequestHandler;
		private wCHandle<TransferSaveData> _transferSaveData;
		private CBool _transferSaveDataSet;
		private CBool _systemRequestsHandlerSet;
		private CBool _cancelButtonHovered;
		private CEnum<TransferSaveState> _currentState;

		[Ordinal(9)] 
		[RED("contentBlock")] 
		public inkWidgetReference ContentBlock
		{
			get => GetProperty(ref _contentBlock);
			set => SetProperty(ref _contentBlock, value);
		}

		[Ordinal(10)] 
		[RED("spinnerBlock")] 
		public inkWidgetReference SpinnerBlock
		{
			get => GetProperty(ref _spinnerBlock);
			set => SetProperty(ref _spinnerBlock, value);
		}

		[Ordinal(11)] 
		[RED("errorBlock")] 
		public inkWidgetReference ErrorBlock
		{
			get => GetProperty(ref _errorBlock);
			set => SetProperty(ref _errorBlock, value);
		}

		[Ordinal(12)] 
		[RED("saveImageContainer")] 
		public inkWidgetReference SaveImageContainer
		{
			get => GetProperty(ref _saveImageContainer);
			set => SetProperty(ref _saveImageContainer, value);
		}

		[Ordinal(13)] 
		[RED("saveImage")] 
		public inkImageWidgetReference SaveImage
		{
			get => GetProperty(ref _saveImage);
			set => SetProperty(ref _saveImage, value);
		}

		[Ordinal(14)] 
		[RED("saveImageEmpty")] 
		public inkWidgetReference SaveImageEmpty
		{
			get => GetProperty(ref _saveImageEmpty);
			set => SetProperty(ref _saveImageEmpty, value);
		}

		[Ordinal(15)] 
		[RED("saveImageSpinner")] 
		public inkWidgetReference SaveImageSpinner
		{
			get => GetProperty(ref _saveImageSpinner);
			set => SetProperty(ref _saveImageSpinner, value);
		}

		[Ordinal(16)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(17)] 
		[RED("spinnerText")] 
		public inkTextWidgetReference SpinnerText
		{
			get => GetProperty(ref _spinnerText);
			set => SetProperty(ref _spinnerText, value);
		}

		[Ordinal(18)] 
		[RED("errorText")] 
		public inkTextWidgetReference ErrorText
		{
			get => GetProperty(ref _errorText);
			set => SetProperty(ref _errorText, value);
		}

		[Ordinal(19)] 
		[RED("proceedButtonWidget")] 
		public inkWidgetReference ProceedButtonWidget
		{
			get => GetProperty(ref _proceedButtonWidget);
			set => SetProperty(ref _proceedButtonWidget, value);
		}

		[Ordinal(20)] 
		[RED("cancelButtonWidget")] 
		public inkWidgetReference CancelButtonWidget
		{
			get => GetProperty(ref _cancelButtonWidget);
			set => SetProperty(ref _cancelButtonWidget, value);
		}

		[Ordinal(21)] 
		[RED("systemRequestHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemRequestHandler
		{
			get => GetProperty(ref _systemRequestHandler);
			set => SetProperty(ref _systemRequestHandler, value);
		}

		[Ordinal(22)] 
		[RED("transferSaveData")] 
		public wCHandle<TransferSaveData> TransferSaveData
		{
			get => GetProperty(ref _transferSaveData);
			set => SetProperty(ref _transferSaveData, value);
		}

		[Ordinal(23)] 
		[RED("transferSaveDataSet")] 
		public CBool TransferSaveDataSet
		{
			get => GetProperty(ref _transferSaveDataSet);
			set => SetProperty(ref _transferSaveDataSet, value);
		}

		[Ordinal(24)] 
		[RED("systemRequestsHandlerSet")] 
		public CBool SystemRequestsHandlerSet
		{
			get => GetProperty(ref _systemRequestsHandlerSet);
			set => SetProperty(ref _systemRequestsHandlerSet, value);
		}

		[Ordinal(25)] 
		[RED("cancelButtonHovered")] 
		public CBool CancelButtonHovered
		{
			get => GetProperty(ref _cancelButtonHovered);
			set => SetProperty(ref _cancelButtonHovered, value);
		}

		[Ordinal(26)] 
		[RED("currentState")] 
		public CEnum<TransferSaveState> CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		public TransferSaveSystemNotificationLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
