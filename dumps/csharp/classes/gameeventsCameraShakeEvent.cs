using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsCameraShakeEvent : redEvent
	{
		private CFloat _shakeStrength;

		[Ordinal(0)] 
		[RED("shakeStrength")] 
		public CFloat ShakeStrength
		{
			get => GetProperty(ref _shakeStrength);
			set => SetProperty(ref _shakeStrength, value);
		}

		public gameeventsCameraShakeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
