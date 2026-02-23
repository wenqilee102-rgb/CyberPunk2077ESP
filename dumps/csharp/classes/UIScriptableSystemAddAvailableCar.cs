using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemAddAvailableCar : gameScriptableSystemRequest
	{
		private CName _carFact;

		[Ordinal(0)] 
		[RED("carFact")] 
		public CName CarFact
		{
			get => GetProperty(ref _carFact);
			set => SetProperty(ref _carFact, value);
		}

		public UIScriptableSystemAddAvailableCar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
