using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDynamicMeshNode : worldMeshNode
	{
		private CBool _startAsleep;
		private CBool _isDebris;
		private CBool _initialGuess;
		private TrafficGenDynamicTrafficSetting _dynamicTrafficSetting;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(18)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get => GetProperty(ref _startAsleep);
			set => SetProperty(ref _startAsleep, value);
		}

		[Ordinal(19)] 
		[RED("isDebris")] 
		public CBool IsDebris
		{
			get => GetProperty(ref _isDebris);
			set => SetProperty(ref _isDebris, value);
		}

		[Ordinal(20)] 
		[RED("initialGuess")] 
		public CBool InitialGuess
		{
			get => GetProperty(ref _initialGuess);
			set => SetProperty(ref _initialGuess, value);
		}

		[Ordinal(21)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetProperty(ref _dynamicTrafficSetting);
			set => SetProperty(ref _dynamicTrafficSetting, value);
		}

		[Ordinal(22)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		[Ordinal(23)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetProperty(ref _useMeshNavmeshSettings);
			set => SetProperty(ref _useMeshNavmeshSettings, value);
		}

		public worldDynamicMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
