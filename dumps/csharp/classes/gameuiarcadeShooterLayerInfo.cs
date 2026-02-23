using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterLayerInfo : CVariable
	{
		private inkWidgetReference _referenceWidget;
		private Vector2 _planeRelativeValue;
		private CName _layerName;

		[Ordinal(0)] 
		[RED("referenceWidget")] 
		public inkWidgetReference ReferenceWidget
		{
			get => GetProperty(ref _referenceWidget);
			set => SetProperty(ref _referenceWidget, value);
		}

		[Ordinal(1)] 
		[RED("planeRelativeValue")] 
		public Vector2 PlaneRelativeValue
		{
			get => GetProperty(ref _planeRelativeValue);
			set => SetProperty(ref _planeRelativeValue, value);
		}

		[Ordinal(2)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetProperty(ref _layerName);
			set => SetProperty(ref _layerName, value);
		}

		public gameuiarcadeShooterLayerInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
