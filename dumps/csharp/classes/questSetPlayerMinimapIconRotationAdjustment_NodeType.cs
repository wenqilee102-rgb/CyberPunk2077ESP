using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPlayerMinimapIconRotationAdjustment_NodeType : questIUIManagerNodeType
	{
		private CFloat _rotationAdjustment;

		[Ordinal(0)] 
		[RED("rotationAdjustment")] 
		public CFloat RotationAdjustment
		{
			get => GetProperty(ref _rotationAdjustment);
			set => SetProperty(ref _rotationAdjustment, value);
		}

		public questSetPlayerMinimapIconRotationAdjustment_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
