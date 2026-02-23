using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGuardAreasSavedState : ISerializable
	{
		private CArray<AIGuardAreaSavedData> _data;
		private CArray<entEntityID> _cleared;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<AIGuardAreaSavedData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("cleared")] 
		public CArray<entEntityID> Cleared
		{
			get => GetProperty(ref _cleared);
			set => SetProperty(ref _cleared, value);
		}

		public AIGuardAreasSavedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
