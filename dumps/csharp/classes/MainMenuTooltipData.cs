using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MainMenuTooltipData : IScriptable
	{
		private CName _identifier;
		private CHandle<ATooltipData> _data;
		private wCHandle<inkWidget> _targetWidget;
		private CEnum<gameuiETooltipPlacement> _placement;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<ATooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("targetWidget")] 
		public wCHandle<inkWidget> TargetWidget
		{
			get => GetProperty(ref _targetWidget);
			set => SetProperty(ref _targetWidget, value);
		}

		[Ordinal(3)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		public MainMenuTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
