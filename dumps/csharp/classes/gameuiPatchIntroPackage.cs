using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPatchIntroPackage : CVariable
	{
		private CArray<CEnum<gameuiPatchIntro>> _patchIntrosNeeded;

		[Ordinal(0)] 
		[RED("patchIntrosNeeded")] 
		public CArray<CEnum<gameuiPatchIntro>> PatchIntrosNeeded
		{
			get => GetProperty(ref _patchIntrosNeeded);
			set => SetProperty(ref _patchIntrosNeeded, value);
		}

		public gameuiPatchIntroPackage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
