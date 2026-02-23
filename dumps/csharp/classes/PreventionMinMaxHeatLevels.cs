using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionMinMaxHeatLevels : gameScriptableSystemRequest
	{
		private CInt32 _minLvl;
		private CInt32 _maxLvl;
		private CBool _isDefault;

		[Ordinal(0)] 
		[RED("minLvl")] 
		public CInt32 MinLvl
		{
			get => GetProperty(ref _minLvl);
			set => SetProperty(ref _minLvl, value);
		}

		[Ordinal(1)] 
		[RED("maxLvl")] 
		public CInt32 MaxLvl
		{
			get => GetProperty(ref _maxLvl);
			set => SetProperty(ref _maxLvl, value);
		}

		[Ordinal(2)] 
		[RED("isDefault")] 
		public CBool IsDefault
		{
			get => GetProperty(ref _isDefault);
			set => SetProperty(ref _isDefault, value);
		}

		public PreventionMinMaxHeatLevels(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
