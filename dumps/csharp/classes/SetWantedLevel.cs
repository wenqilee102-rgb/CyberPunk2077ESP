using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetWantedLevel : gameScriptableSystemRequest
	{
		private CEnum<EPreventionHeatStage> _wantedLevel;
		private CBool _forceGreyStars;
		private CBool _resetGreyStars;
		private CBool _forcePlayerPositionAsLastCrimePoint;
		private CBool _forceIgnoreSecurityAreas;

		[Ordinal(0)] 
		[RED("wantedLevel")] 
		public CEnum<EPreventionHeatStage> WantedLevel
		{
			get => GetProperty(ref _wantedLevel);
			set => SetProperty(ref _wantedLevel, value);
		}

		[Ordinal(1)] 
		[RED("forceGreyStars")] 
		public CBool ForceGreyStars
		{
			get => GetProperty(ref _forceGreyStars);
			set => SetProperty(ref _forceGreyStars, value);
		}

		[Ordinal(2)] 
		[RED("resetGreyStars")] 
		public CBool ResetGreyStars
		{
			get => GetProperty(ref _resetGreyStars);
			set => SetProperty(ref _resetGreyStars, value);
		}

		[Ordinal(3)] 
		[RED("forcePlayerPositionAsLastCrimePoint")] 
		public CBool ForcePlayerPositionAsLastCrimePoint
		{
			get => GetProperty(ref _forcePlayerPositionAsLastCrimePoint);
			set => SetProperty(ref _forcePlayerPositionAsLastCrimePoint, value);
		}

		[Ordinal(4)] 
		[RED("forceIgnoreSecurityAreas")] 
		public CBool ForceIgnoreSecurityAreas
		{
			get => GetProperty(ref _forceIgnoreSecurityAreas);
			set => SetProperty(ref _forceIgnoreSecurityAreas, value);
		}

		public SetWantedLevel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
