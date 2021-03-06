using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V281.Segment;
using NHapi.Model.V281.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V281.Group
{
///<summary>
///Represents the EHC_E10_INVOICE_PROCESSING_RESULTS_INFO Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: IPR (Invoice Processing Results) </li>
///<li>1: NTE (Notes and Comments) optional repeating</li>
///<li>2: PYE (Payee Information) </li>
///<li>3: IN1 (Insurance) </li>
///<li>4: IN2 (Insurance Additional Information) optional </li>
///<li>5: IVC (Invoice Segment) </li>
///<li>6: EHC_E10_PSSPSGPSLADJ (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class EHC_E10_INVOICE_PROCESSING_RESULTS_INFO : AbstractGroup {

	///<summary> 
	/// Creates a new EHC_E10_INVOICE_PROCESSING_RESULTS_INFO Group.
	///</summary>
	public EHC_E10_INVOICE_PROCESSING_RESULTS_INFO(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(IPR), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(PYE), true, false);
	      this.add(typeof(IN1), true, false);
	      this.add(typeof(IN2), false, false);
	      this.add(typeof(IVC), true, false);
	      this.add(typeof(EHC_E10_PSSPSGPSLADJ), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EHC_E10_INVOICE_PROCESSING_RESULTS_INFO - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns IPR (Invoice Processing Results) - creates it if necessary
	///</summary>
	public IPR IPR { 
get{
	   IPR ret = null;
	   try {
	      ret = (IPR)this.GetStructure("IPR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns PYE (Payee Information) - creates it if necessary
	///</summary>
	public PYE PYE { 
get{
	   PYE ret = null;
	   try {
	      ret = (PYE)this.GetStructure("PYE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns IN1 (Insurance) - creates it if necessary
	///</summary>
	public IN1 IN1 { 
get{
	   IN1 ret = null;
	   try {
	      ret = (IN1)this.GetStructure("IN1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns IN2 (Insurance Additional Information) - creates it if necessary
	///</summary>
	public IN2 IN2 { 
get{
	   IN2 ret = null;
	   try {
	      ret = (IN2)this.GetStructure("IN2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns IVC (Invoice Segment) - creates it if necessary
	///</summary>
	public IVC IVC { 
get{
	   IVC ret = null;
	   try {
	      ret = (IVC)this.GetStructure("IVC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of EHC_E10_PSSPSGPSLADJ (a Group object) - creates it if necessary
	///</summary>
	public EHC_E10_PSSPSGPSLADJ GetPSSPSGPSLADJ() {
	   EHC_E10_PSSPSGPSLADJ ret = null;
	   try {
	      ret = (EHC_E10_PSSPSGPSLADJ)this.GetStructure("PSSPSGPSLADJ");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of EHC_E10_PSSPSGPSLADJ
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public EHC_E10_PSSPSGPSLADJ GetPSSPSGPSLADJ(int rep) { 
	   return (EHC_E10_PSSPSGPSLADJ)this.GetStructure("PSSPSGPSLADJ", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EHC_E10_PSSPSGPSLADJ 
	 */ 
	public int PSSPSGPSLADJRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PSSPSGPSLADJ").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the EHC_E10_PSSPSGPSLADJ results 
	 */ 
	public IEnumerable<EHC_E10_PSSPSGPSLADJ> PSSPSGPSLADJs 
	{ 
		get
		{
			for (int rep = 0; rep < PSSPSGPSLADJRepetitionsUsed; rep++)
			{
				yield return (EHC_E10_PSSPSGPSLADJ)this.GetStructure("PSSPSGPSLADJ", rep);
			}
		}
	}

	///<summary>
	///Adds a new EHC_E10_PSSPSGPSLADJ
	///</summary>
	public EHC_E10_PSSPSGPSLADJ AddPSSPSGPSLADJ()
	{
		return this.AddStructure("PSSPSGPSLADJ") as EHC_E10_PSSPSGPSLADJ;
	}

	///<summary>
	///Removes the given EHC_E10_PSSPSGPSLADJ
	///</summary>
	public void RemovePSSPSGPSLADJ(EHC_E10_PSSPSGPSLADJ toRemove)
	{
		this.RemoveStructure("PSSPSGPSLADJ", toRemove);
	}

	///<summary>
	///Removes the EHC_E10_PSSPSGPSLADJ at the given index
	///</summary>
	public void RemovePSSPSGPSLADJAt(int index)
	{
		this.RemoveRepetition("PSSPSGPSLADJ", index);
	}

}
}
