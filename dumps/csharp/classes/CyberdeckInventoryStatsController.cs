using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckInventoryStatsController : inkWidgetLogicController
	{
		private inkTextWidgetReference _bufferTotal;
		private inkTextWidgetReference _bufferBase;
		private inkTextWidgetReference _bufferBonus;
		private inkWidgetReference _bufferHoverArea;
		private CEnum<gameuiETooltipPlacement> _bufferTooltipPlacement;
		private inkTextWidgetReference _ramTotal;
		private inkTextWidgetReference _ramBase;
		private inkTextWidgetReference _ramBonus;
		private inkWidgetReference _ramHoverArea;
		private CEnum<gameuiETooltipPlacement> _ramTooltipPlacement;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(1)] 
		[RED("bufferTotal")] 
		public inkTextWidgetReference BufferTotal
		{
			get => GetProperty(ref _bufferTotal);
			set => SetProperty(ref _bufferTotal, value);
		}

		[Ordinal(2)] 
		[RED("bufferBase")] 
		public inkTextWidgetReference BufferBase
		{
			get => GetProperty(ref _bufferBase);
			set => SetProperty(ref _bufferBase, value);
		}

		[Ordinal(3)] 
		[RED("bufferBonus")] 
		public inkTextWidgetReference BufferBonus
		{
			get => GetProperty(ref _bufferBonus);
			set => SetProperty(ref _bufferBonus, value);
		}

		[Ordinal(4)] 
		[RED("bufferHoverArea")] 
		public inkWidgetReference BufferHoverArea
		{
			get => GetProperty(ref _bufferHoverArea);
			set => SetProperty(ref _bufferHoverArea, value);
		}

		[Ordinal(5)] 
		[RED("bufferTooltipPlacement")] 
		public CEnum<gameuiETooltipPlacement> BufferTooltipPlacement
		{
			get => GetProperty(ref _bufferTooltipPlacement);
			set => SetProperty(ref _bufferTooltipPlacement, value);
		}

		[Ordinal(6)] 
		[RED("ramTotal")] 
		public inkTextWidgetReference RamTotal
		{
			get => GetProperty(ref _ramTotal);
			set => SetProperty(ref _ramTotal, value);
		}

		[Ordinal(7)] 
		[RED("ramBase")] 
		public inkTextWidgetReference RamBase
		{
			get => GetProperty(ref _ramBase);
			set => SetProperty(ref _ramBase, value);
		}

		[Ordinal(8)] 
		[RED("ramBonus")] 
		public inkTextWidgetReference RamBonus
		{
			get => GetProperty(ref _ramBonus);
			set => SetProperty(ref _ramBonus, value);
		}

		[Ordinal(9)] 
		[RED("ramHoverArea")] 
		public inkWidgetReference RamHoverArea
		{
			get => GetProperty(ref _ramHoverArea);
			set => SetProperty(ref _ramHoverArea, value);
		}

		[Ordinal(10)] 
		[RED("ramTooltipPlacement")] 
		public CEnum<gameuiETooltipPlacement> RamTooltipPlacement
		{
			get => GetProperty(ref _ramTooltipPlacement);
			set => SetProperty(ref _ramTooltipPlacement, value);
		}

		[Ordinal(11)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		public CyberdeckInventoryStatsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
