using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buffListItemLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _iconBg;
		private inkWidgetReference _fill;
		private wCHandle<inkWidget> _fillWidget;
		private inkTextWidgetReference _timeLabel;
		private inkTextWidgetReference _stackCounter;
		private inkWidgetReference _stackCounterContainer;
		private wCHandle<gamedataStatusEffect_Record> _statusEffectRecord;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("iconBg")] 
		public inkImageWidgetReference IconBg
		{
			get => GetProperty(ref _iconBg);
			set => SetProperty(ref _iconBg, value);
		}

		[Ordinal(3)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get => GetProperty(ref _fill);
			set => SetProperty(ref _fill, value);
		}

		[Ordinal(4)] 
		[RED("fillWidget")] 
		public wCHandle<inkWidget> FillWidget
		{
			get => GetProperty(ref _fillWidget);
			set => SetProperty(ref _fillWidget, value);
		}

		[Ordinal(5)] 
		[RED("timeLabel")] 
		public inkTextWidgetReference TimeLabel
		{
			get => GetProperty(ref _timeLabel);
			set => SetProperty(ref _timeLabel, value);
		}

		[Ordinal(6)] 
		[RED("stackCounter")] 
		public inkTextWidgetReference StackCounter
		{
			get => GetProperty(ref _stackCounter);
			set => SetProperty(ref _stackCounter, value);
		}

		[Ordinal(7)] 
		[RED("stackCounterContainer")] 
		public inkWidgetReference StackCounterContainer
		{
			get => GetProperty(ref _stackCounterContainer);
			set => SetProperty(ref _stackCounterContainer, value);
		}

		[Ordinal(8)] 
		[RED("statusEffectRecord")] 
		public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		public buffListItemLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
