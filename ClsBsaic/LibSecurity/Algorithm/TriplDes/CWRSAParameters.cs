using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The TriplDes namespace.
/// </summary>
namespace ClsBsaic.LibSecurity.Algorithm.TriplDes
{
    /// <summary>
    ///  表示 System.Security.Cryptography.RSA 算法的标准参数.
    /// </summary>
   public class CWRSAParameters
    {
        /// <summary>
        ///  表示 RSA 算法的 D 参数.
        /// </summary>
        /// <value>The command.</value>
       public byte[] D
       {
           get;
           set;
       }
    
       /// <summary>
       /// 表示 RSA 算法的 DP 参数.
       /// </summary>
       /// <value>The dp.</value>
       public byte[] DP
       {
           get;
           set;
       }
       
       /// <summary>
       /// 表示 RSA 算法的 DQ 参数.
       /// </summary>
       /// <value>The dq.</value>
       public byte[] DQ
       {
           get;
           set;
       }
    
       /// <summary>
       /// 表示 RSA 算法的 Exponent 参数.
       /// </summary>
       /// <value>The exponent.</value>
       public byte[] Exponent
       {
           get;
           set;
       }
 
       /// <summary>
       ///  表示 RSA 算法的 InverseQ 参数.
       /// </summary>
       /// <value>The inverse q.</value>
       public byte[] InverseQ
       {
           get;
           set;
       }
       
       /// <summary>
       /// 表示 RSA 算法的 Modulus 参数.
       /// </summary>
       /// <value>The modulus.</value>
       public byte[] Modulus
       {
           get;
           set;
       }
       
       /// <summary>
       ///  表示 RSA 算法的 P 参数.
       /// </summary>
       /// <value>The application.</value>
       public byte[] P
       {
           get;
           set;
       }
        
       /// <summary>
       /// 表示 RSA 算法的 Q 参数.
       /// </summary>
       /// <value>The q.</value>
       public byte[] Q
       {
           get;
           set;
       }
    }
}
