using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareInventoryMiniGrid : inkWidgetLogicController
	{
		private CBool _isLeftAligned;
		private inkUniformGridWidgetReference _gridContainer;
		private inkTextWidgetReference _label;
		private inkWidgetReference _isNew;
		private CInt32 _selectedSlotIndex;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CHandle<IScriptable> _parentObject;
		private CName _onRealeaseCallbackName;
		private CHandle<inkanimProxy> _opacityAnimation;
		private CHandle<inkanimProxy> _marginAnimation;
		private CHandle<inkanimProxy> _labelAnimation;
		private CHandle<PulseAnimation> _labelPulse;
		private inkMargin _margin;
		private inkMargin _targetMargin;
		private inkCompoundWidgetReference _parent;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _minigridAnimation;
		private CEnum<CyberwareScreenType> _screen;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CArray<wCHandle<InventoryItemDisplayController>> _gridData;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("isLeftAligned")] 
		public CBool IsLeftAligned
		{
			get => GetProperty(ref _isLeftAligned);
			set => SetProperty(ref _isLeftAligned, value);
		}

		[Ordinal(2)] 
		[RED("gridContainer")] 
		public inkUniformGridWidgetReference GridContainer
		{
			get => GetProperty(ref _gridContainer);
			set => SetProperty(ref _gridContainer, value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(4)] 
		[RED("isNew")] 
		public inkWidgetReference IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(5)] 
		[RED("selectedSlotIndex")] 
		public CInt32 SelectedSlotIndex
		{
			get => GetProperty(ref _selectedSlotIndex);
			set => SetProperty(ref _selectedSlotIndex, value);
		}

		[Ordinal(6)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(7)] 
		[RED("parentObject")] 
		public CHandle<IScriptable> ParentObject
		{
			get => GetProperty(ref _parentObject);
			set => SetProperty(ref _parentObject, value);
		}

		[Ordinal(8)] 
		[RED("onRealeaseCallbackName")] 
		public CName OnRealeaseCallbackName
		{
			get => GetProperty(ref _onRealeaseCallbackName);
			set => SetProperty(ref _onRealeaseCallbackName, value);
		}

		[Ordinal(9)] 
		[RED("opacityAnimation")] 
		public CHandle<inkanimProxy> OpacityAnimation
		{
			get => GetProperty(ref _opacityAnimation);
			set => SetProperty(ref _opacityAnimation, value);
		}

		[Ordinal(10)] 
		[RED("marginAnimation")] 
		public CHandle<inkanimProxy> MarginAnimation
		{
			get => GetProperty(ref _marginAnimation);
			set => SetProperty(ref _marginAnimation, value);
		}

		[Ordinal(11)] 
		[RED("labelAnimation")] 
		public CHandle<inkanimProxy> LabelAnimation
		{
			get => GetProperty(ref _labelAnimation);
			set => SetProperty(ref _labelAnimation, value);
		}

		[Ordinal(12)] 
		[RED("labelPulse")] 
		public CHandle<PulseAnimation> LabelPulse
		{
			get => GetProperty(ref _labelPulse);
			set => SetProperty(ref _labelPulse, value);
		}

		[Ordinal(13)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(14)] 
		[RED("targetMargin")] 
		public inkMargin TargetMargin
		{
			get => GetProperty(ref _targetMargin);
			set => SetProperty(ref _targetMargin, value);
		}

		[Ordinal(15)] 
		[RED("parent")] 
		public inkCompoundWidgetReference Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(17)] 
		[RED("minigridAnimation")] 
		public CHandle<inkanimProxy> MinigridAnimation
		{
			get => GetProperty(ref _minigridAnimation);
			set => SetProperty(ref _minigridAnimation, value);
		}

		[Ordinal(18)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetProperty(ref _screen);
			set => SetProperty(ref _screen, value);
		}

		[Ordinal(19)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(20)] 
		[RED("gridData")] 
		public CArray<wCHandle<InventoryItemDisplayController>> GridData
		{
			get => GetProperty(ref _gridData);
			set => SetProperty(ref _gridData, value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public CyberwareInventoryMiniGrid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
