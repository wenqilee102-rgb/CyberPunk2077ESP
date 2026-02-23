using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_Laser : gameEffectObjectProvider_PhysicalRay
	{
		private CUInt32 _inputTracesPerSecond;
		private Vector4 _inputRayOffset;

		[Ordinal(6)] 
		[RED("inputTracesPerSecond")] 
		public CUInt32 InputTracesPerSecond
		{
			get => GetProperty(ref _inputTracesPerSecond);
			set => SetProperty(ref _inputTracesPerSecond, value);
		}

		[Ordinal(7)] 
		[RED("inputRayOffset")] 
		public Vector4 InputRayOffset
		{
			get => GetProperty(ref _inputRayOffset);
			set => SetProperty(ref _inputRayOffset, value);
		}

		public gameEffectObjectProvider_Laser(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
