using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		private CColor _noneColor;
		private CColor _hasProxyColor;
		private CColor _discardColor;

		[Ordinal(0)] 
		[RED("noneColor")] 
		public CColor NoneColor
		{
			get => GetProperty(ref _noneColor);
			set => SetProperty(ref _noneColor, value);
		}

		[Ordinal(1)] 
		[RED("hasProxyColor")] 
		public CColor HasProxyColor
		{
			get => GetProperty(ref _hasProxyColor);
			set => SetProperty(ref _hasProxyColor, value);
		}

		[Ordinal(2)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get => GetProperty(ref _discardColor);
			set => SetProperty(ref _discardColor, value);
		}

		public worldDebugColoring_ProxyMeshDependency(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
