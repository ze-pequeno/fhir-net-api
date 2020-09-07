﻿/* 
 * Copyright (c) 2020, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/FirelyTeam/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;

namespace Hl7.Fhir.Specification.Specification.Terminology
{
    public class ExpandParameters
    {
        /// <summary>
        /// A canonical reference to a value set.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The value set is provided directly as part of the request.
        /// </summary>
        public Resource ValueSet { get; set; }
        /// <summary>
        /// The identifier that is used to identify a specific version of the value set to be used when generating the expansion.
        /// </summary>
        public string ValueSetVersion { get; set; }
        /// <summary>
        /// The context of the value set, so that the server can resolve this to a value set to expand.
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// If a context is provided, a context direction may also be provided.
        /// </summary>
        public ContextDirection? ContextDirection { get; set; }
        /// <summary>
        /// A text filter that is applied to restrict the codes that are returned.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// The date for which the expansion should be generated.
        /// </summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>
        /// Where to start if a subset is desired (default = 0)
        /// </summary>
        public int? Offset { get; set; }
        /// <summary>
        /// How many codes should be provided in a partial page view
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Controls whether concept designations are to be included or excluded in value set expansions.
        /// </summary>
        public bool? IncludeDesignations { get; set; }
        /// <summary>
        /// A token that specifies a system+code that is either a use or a language.
        /// </summary>
        public List<string> Designation { get; set; }
        /// <summary>
        /// Controls whether the value set definition is included or excluded in value set expansions.
        /// </summary>
        public bool? IncludeDefinition { get; set; }
        /// <summary>
        /// Controls whether inactive concepts are included or excluded in value set expansions.
        /// </summary>
        public bool? ActiveOnly { get; set; }
        /// <summary>
        /// Controls whether or not the value set expansion nests codes or not (i.e. ValueSet.expansion.contains.contains).
        /// </summary>
        public bool? ExcludeNested { get; set; }
        /// <summary>
        /// Controls whether or not the value set expansion is assembled for a user interface use or not.
        /// </summary>
        public bool? ExcludeNotForUI { get; set; }
        /// <summary>
        /// Controls whether or not the value set expansion includes post coordinated codes.
        /// </summary>
        public bool? ExcludePostCoordinated { get; set; }
        /// <summary>
        /// Specifies the language to be used for description in the expansions i.e. the language to be used for ValueSet.expansion.contains.display
        /// </summary>
        public string DisplayLanguage { get; set; }
        /// <summary>
        /// Code system, or a particular version of a code system to be excluded from the value set expansion.
        /// </summary>
        /// <remarks> The format is the same as a canonical URL: [system]|[version] - e.g. http://loinc.org|2.56.</remarks>
        public List<string> ExcludeSystem { get; set; }
        /// <summary>
        /// Specifies a version to use for a system, if the value set does not specify which one to use.
        /// </summary>
        /// <remarks>The format is the same as a canonical URL: [system]|[version] - e.g. http://loinc.org|2.56.</remarks>
        public List<string> SystemVersion { get; set; }
        /// <summary>
        /// Specifies a version to use for a system. If a value set specifies a different version, an error is returned instead of the expansion.
        /// </summary>
        /// <remarks>The format is the same as a canonical URL: [system]|[version] - e.g. http://loinc.org|2.56.</remarks>
        public List<string> CheckSystemVersion { get; set; }
        /// <summary>
        /// Specifies a version to use for a system. This parameter overrides any specified version in the value set (and any it depends on).
        /// </summary>
        /// <remarks>The format is the same as a canonical URL: [system]|[version] - e.g. http://loinc.org|2.56.</remarks>
        public List<string> ForceSystemVersion { get; set; }
    }
}
