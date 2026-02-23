using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatchNotesCheckData : IScriptable
	{
		private CBool _ownExpansion;

		[Ordinal(0)] 
		[RED("ownExpansion")] 
		public CBool OwnExpansion
		{
			get => GetProperty(ref _ownExpansion);
			set => SetProperty(ref _ownExpansion, value);
		}

		public PatchNotesCheckData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
