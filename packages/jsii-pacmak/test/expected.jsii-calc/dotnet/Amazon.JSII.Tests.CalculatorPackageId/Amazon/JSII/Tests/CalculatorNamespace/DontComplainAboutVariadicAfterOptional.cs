using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <summary></summary>
    /// <remarks>
    /// stability: Experimental
    /// </remarks>
    [JsiiClass(nativeType: typeof(Amazon.JSII.Tests.CalculatorNamespace.DontComplainAboutVariadicAfterOptional), fullyQualifiedName: "jsii-calc.DontComplainAboutVariadicAfterOptional")]
    public class DontComplainAboutVariadicAfterOptional : DeputyBase
    {
        /// <summary></summary>
        public DontComplainAboutVariadicAfterOptional(): base(new DeputyProps(new object[]{}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        protected DontComplainAboutVariadicAfterOptional(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        protected DontComplainAboutVariadicAfterOptional(DeputyProps props): base(props)
        {
        }

        /// <summary></summary>
        /// <param name="optional"></param>
        /// <param name="things"></param>
        /// <remarks>
        /// stability: Experimental
        /// </remarks>
        [JsiiMethod(name: "optionalAndVariadic", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"optional\",\"optional\":true,\"type\":{\"primitive\":\"string\"}},{\"name\":\"things\",\"type\":{\"primitive\":\"string\"},\"variadic\":true}]")]
        public virtual string OptionalAndVariadic(string optional = null, params string[] things)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string), typeof(string[])}, new object[]{optional, things});
        }
    }
}
