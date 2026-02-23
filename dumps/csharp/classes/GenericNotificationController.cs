using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _textRef;
		private inkTextWidgetReference _actionLabelRef;
		private inkWidgetReference _actionRef;
		private CBool _paused;
		private CBool _blockAction;
		private wCHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CHandle<gameuiGenericNotificationViewData> _data;
		private wCHandle<gameObject> _player;
		private CBool _isInteractive;
		private CName _customInputActionName;

		[Ordinal(5)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetProperty(ref _titleRef);
			set => SetProperty(ref _titleRef, value);
		}

		[Ordinal(6)] 
		[RED("textRef")] 
		public inkTextWidgetReference TextRef
		{
			get => GetProperty(ref _textRef);
			set => SetProperty(ref _textRef, value);
		}

		[Ordinal(7)] 
		[RED("actionLabelRef")] 
		public inkTextWidgetReference ActionLabelRef
		{
			get => GetProperty(ref _actionLabelRef);
			set => SetProperty(ref _actionLabelRef, value);
		}

		[Ordinal(8)] 
		[RED("actionRef")] 
		public inkWidgetReference ActionRef
		{
			get => GetProperty(ref _actionRef);
			set => SetProperty(ref _actionRef, value);
		}

		[Ordinal(9)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetProperty(ref _paused);
			set => SetProperty(ref _paused, value);
		}

		[Ordinal(10)] 
		[RED("blockAction")] 
		public CBool BlockAction
		{
			get => GetProperty(ref _blockAction);
			set => SetProperty(ref _blockAction, value);
		}

		[Ordinal(11)] 
		[RED("translationAnimationCtrl")] 
		public wCHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<gameuiGenericNotificationViewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(13)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(14)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(15)] 
		[RED("customInputActionName")] 
		public CName CustomInputActionName
		{
			get => GetProperty(ref _customInputActionName);
			set => SetProperty(ref _customInputActionName, value);
		}

		public GenericNotificationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
