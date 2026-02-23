using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ProceduralDriverCombatData : animAnimFeature
	{
		private CBool _isEnabled;
		private CBool _yawDirectionFlipped;
		private CFloat _yaw;
		private CFloat _pitch;
		private CFloat _roll;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(1)] 
		[RED("yawDirectionFlipped")] 
		public CBool YawDirectionFlipped
		{
			get => GetProperty(ref _yawDirectionFlipped);
			set => SetProperty(ref _yawDirectionFlipped, value);
		}

		[Ordinal(2)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(4)] 
		[RED("roll")] 
		public CFloat Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}

		public AnimFeature_ProceduralDriverCombatData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
