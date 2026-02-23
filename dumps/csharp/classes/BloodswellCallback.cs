using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloodswellCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CHandle<BloodswellEffector> _bloodswellEffector;

		[Ordinal(0)] 
		[RED("bloodswellEffector")] 
		public CHandle<BloodswellEffector> BloodswellEffector
		{
			get => GetProperty(ref _bloodswellEffector);
			set => SetProperty(ref _bloodswellEffector, value);
		}

		public BloodswellCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
