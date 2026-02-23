using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationBodyMorphBaseOption : inkWidgetLogicController
	{
		private CBool _isPrevOrNextBtnHoveredOver;

		[Ordinal(1)] 
		[RED("isPrevOrNextBtnHoveredOver")] 
		public CBool IsPrevOrNextBtnHoveredOver
		{
			get => GetProperty(ref _isPrevOrNextBtnHoveredOver);
			set => SetProperty(ref _isPrevOrNextBtnHoveredOver, value);
		}

		public CharacterCreationBodyMorphBaseOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
