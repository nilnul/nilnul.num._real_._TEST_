using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Diagnostics;
using t= Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient.all;
using q = nilnul.num.quotient;

namespace nilnul.num.real._test._real.approach_.tau_
{
	[TestClass]
	public class UnitTest1
	{


		public const string refValTxt=
			"6.2831853071795864769252867665590057683943387987502116419498891846156328125724179972560696506842341359642961730265646132941876892191011644634507188162569622349005682054038770422111192892458979098607639288576219513318668922569512964675735663305424038182912971338469206972209086532964267872145204982825474491740132126311763497630418419256585081834307287357851807200226610610976409330427682939038830232188661145407315191839061843722347638652235862102370961489247599254991347037715054497824558763660238982596673467248813132861720427898927904494743814043597218874055410784343525863535047693496369353388102640011362542905271216555715426855155792183472743574429368818024499068602930991707421015845593785178470840399122242580439217280688363196272595495426199210374144226999999967459560999021194634656321926371900489189106938166052850446165066893700705238623763420200062756775057731750664167628412343553382946071965069808575109374623191257277647075751875039155637155610643424536132260038557532223918184328403978761905144021309717265577318723067636559364606039040706037059379915472451988277824994435505669582630311497144849083013919016590662337234557117781501967635092749298786385101208018554033422780196976480257167232071274153202094203638859111923978935356748988965107595494536942080950692924160933685181389825866273540579783042095043241139320481160763003870225067648600711752804949929465278283985452085398455935647095632720186834432824398491726300605723659491114134996770109891771738539913818544215950186059106423306899744055119204729613309982397636695955071327396148530850557251036368351493457819555455876001632941200322904983843464344295447002828839471370963227223147051042669514836989368770466478147882866690955248337250379671389711241984384443685451005085137753435809892033069336099772544655835721715687676559359533629082019077675727219013601284502504102347859697921682569772538912084839305700444213223726134885572440783898900942474275739219127287438345749355293151479248277817316652919916267809560551801989315281579025389367967051914196516452410449788154534389565369652029539818052802727888749106101364069925049034987993028628596183813185018744433929230314197167748211957719195459509978603235078569362765373677378855483119837118504919079188620999450493616919745472893916973076734724452521982492161024877687809024882730995255615954313828719954002592321788833897371116968127068441444516569772963169120570120336854789045349353577905042770450999093334556479729131922327097724611549129960711872691363486482250301521389589021931921880504577594217862913382737344574978811202030066172358573618417495218356498771780194298193519705227310995637862595696433659978974453176097151280285409551102647592829030474924687290857168895905317356421022827094714790462268543322042719390724628859049698743742202915308071805598688074840146211570781243967748956169569793666428914277375038870128604369063820969620107412293613498385563823958799041228393268575088812874902474363843599967820318391236293502853824794978818143729884639231358904161902931004504632077638602841875242757119132778755741660781395841546934443651251993230028430061360768954690984052108293318504029948857014650373320042648681763814209726634692993029078115925371220110162133175939963271494727681051429182057941282802219424125608780795190313543154008406757398720144611175263527188437462502942410658563836523722517346431583968296976583289412191505413914441835134233445821963381830560347013425497166445743670418707931450242167158302739764182888420135020669342206282534222739817317032796630039403303023370342875315236703113017698199797199647746910566632710152958370717864523709792642658661797141284093505181418309"
		;

		private static readonly Q refVal = nilnul.num.quotient.radix.Dec.Parse(refValTxt);

	//	nilnul.num.quotient.Neighbor precision;

		nilnul.num.quotient.Range refRange;


		int refPrecision;
		public UnitTest1()
		{
			

			var refValHalf__length= refValTxt.Length;

			 refPrecision = refValHalf__length - 2;

			var unitFrac = Q._CreateUnit(nilnul.num.op.Pow.Do_basePlural_indexNonNeg(
				10, 
				refPrecision
				));


			 //precision = nilnul.num.quotient.Neighbor.Create(
				//	refVal,
				//	unitFrac
				//);

			 refRange = new quotient.Range( nilnul.num.quotient.Range.CreateOpen(
				refVal,
				
				refVal + 	unitFrac	/// if it's       0 .xxxxx...y99999999....
			));




		}

		[TestMethod]
		public void tau()
		{
			var unitFracDen = 1000;
			_e(unitFracDen);

			_e(1000000000000000000);

			_tau_clamp2digitsafterDot(100);


		}

		[TestMethod]
		public void tau_digitsAftDot()
		{
			Debug.WriteLine(refPrecision);

			




			_tau_clamp2digitsafterDot(1);

			_tau_clamp2digitsafterDot(10);
			_tau_clamp2digitsafterDot(100);
			//_tau_clamp2digitsafterDot(refPrecision);	//note the integer and the dot char


		}


		[TestMethod]
		public void tau_digitsAftDot_long()
		{
			Debug.WriteLine(refPrecision);

			




			_tau_clamp2digitsafterDot(1);

			_tau_clamp2digitsafterDot(10);
			//_e_clamp2digitsafterDot(100);
			_tau_clamp2digitsafterDot(refPrecision);	//note the integer and the dot char


		}

		private void _e(long unitFracDen) {

			var e = new nilnul.num._real.approach_.tau_.Tau_a_();

			e._Clamp2UnitFrac(unitFracDen  );


			t.Assert.IsTrue(

				nilnul.num.quotient.Neighbor.Create(
					refVal, 
					Q._CreateUnit(unitFracDen)
				).contains(
					 e.bound.midPoint
				 )
			);


		}

		private void _tau_clamp2digitsafterDot(long digitsAftDot) {

			var unitFrac =  Q._CreateUnit(nilnul.num.op.Pow.Do_basePlural_indexNonNeg(10, digitsAftDot));


			var e = new nilnul.num._real.approach_.tau_.Tau_a_();


			e.Clamp(unitFrac);


			var joint = q.range.rel_.Joint.Singleton.contains(
				e.bound,
				
				refRange	
			);






			var midPoint = e.bound.midPoint;



			Debug.WriteLine(
				nilnul.num.quotient.radix.Dec.FroQuotient(
					midPoint
					,digitsAftDot	+1
				)
			);

			t.Assert.IsTrue(

				joint
			);


		}
	}
}