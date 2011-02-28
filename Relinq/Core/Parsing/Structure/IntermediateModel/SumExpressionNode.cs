// This file is part of the re-motion Core Framework (www.re-motion.org)
// Copyright (C) 2005-2009 rubicon informationstechnologie gmbh, www.rubicon.eu
// 
// The re-motion Core Framework is free software; you can redistribute it 
// and/or modify it under the terms of the GNU Lesser General Public License 
// as published by the Free Software Foundation; either version 2.1 of the 
// License, or (at your option) any later version.
// 
// re-motion is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with re-motion; if not, see http://www.gnu.org/licenses.
// 
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Remotion.Linq.Clauses;
using Remotion.Linq.Clauses.ResultOperators;
using Remotion.Linq.Utilities;

namespace Remotion.Linq.Parsing.Structure.IntermediateModel
{
  /// <summary>
  /// Represents a <see cref="MethodCallExpression"/> for the different overloads of <see cref="Queryable.Sum"/>.
  /// It is generated by <see cref="ExpressionTreeParser"/> when an <see cref="Expression"/> tree is parsed.
  /// When this node is used, it marks the beginning (i.e. the last node) of an <see cref="IExpressionNode"/> chain that represents a query.
  /// </summary>
  public class SumExpressionNode : ResultOperatorExpressionNodeBase
  {
    public static readonly MethodInfo[] SupportedMethods = new[]
                                                           {
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<decimal>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<decimal?>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<double>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<double?>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<int>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<int?>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<long>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<long?>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<float>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum ((IQueryable<float?>) null)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (decimal) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (decimal?) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (double) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (double?) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (int) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (int?) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (long) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (long?) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (float) 0)),
                                                               GetSupportedMethod (() => Queryable.Sum<object> (null, o => (float?) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<decimal>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<decimal?>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<double>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<double?>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<int>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<int?>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<long>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<long?>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<float>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum ((IEnumerable<float?>) null)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (decimal) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (decimal?) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (double) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (double?) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (int) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (int?) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (long) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (long?) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (float) 0)),
                                                               GetSupportedMethod (() => Enumerable.Sum<object> (null, o => (float?) 0)),
                                                           };

    public SumExpressionNode (MethodCallExpressionParseInfo parseInfo, LambdaExpression optionalSelector)
        : base (parseInfo, null, optionalSelector)
    {
    }

    public override Expression Resolve (
        ParameterExpression inputParameter, Expression expressionToBeResolved, ClauseGenerationContext clauseGenerationContext)
    {
      ArgumentUtility.CheckNotNull ("inputParameter", inputParameter);
      ArgumentUtility.CheckNotNull ("expressionToBeResolved", expressionToBeResolved);

      // no data streams out from this node, so we cannot resolve any expressions
      throw CreateResolveNotSupportedException();
    }

    protected override ResultOperatorBase CreateResultOperator (ClauseGenerationContext clauseGenerationContext)
    {
      return new SumResultOperator();
    }
  }
}
