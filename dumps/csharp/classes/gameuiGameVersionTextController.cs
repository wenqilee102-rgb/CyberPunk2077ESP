using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGameVersionTextController : inkWidgetLogicController
	{
		private inkTextWidgetReference _gameVersionText;
		private inkCompoundWidgetReference _expansionWrapper;
		private inkCompoundWidgetReference _fluffWrapper;

		[Ordinal(1)] 
		[RED("gameVersionText")] 
		public inkTextWidgetReference GameVersionText
		{
			get => GetProperty(ref _gameVersionText);
			set => SetProperty(ref _gameVersionText, value);
		}

		[Ordinal(2)] 
		[RED("expansionWrapper")] 
		public inkCompoundWidgetReference ExpansionWrapper
		{
			get => GetProperty(ref _expansionWrapper);
			set => SetProperty(ref _expansionWrapper, value);
		}

		[Ordinal(3)] 
		[RED("fluffWrapper")] 
		public inkCompoundWidgetReference FluffWrapper
		{
			get => GetProperty(ref _fluffWrapper);
			set => SetProperty(ref _fluffWrapper, value);
		}

		public gameuiGameVersionTextController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
