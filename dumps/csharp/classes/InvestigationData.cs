using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InvestigationData : CVariable
	{
		private worldGlobalNodeRef _globalNodeRef;
		private CArray<Vector4> _investigationPositionsArray;

		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetProperty(ref _globalNodeRef);
			set => SetProperty(ref _globalNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetProperty(ref _investigationPositionsArray);
			set => SetProperty(ref _investigationPositionsArray, value);
		}

		public InvestigationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
