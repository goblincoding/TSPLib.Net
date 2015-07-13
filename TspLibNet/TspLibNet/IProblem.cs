﻿/* The MIT License (MIT)
*
* Copyright (c) 2014 Pawel Drozdowski
*
* Permission is hereby granted, free of charge, to any person obtaining a copy of
* this software and associated documentation files (the "Software"), to deal in
* the Software without restriction, including without limitation the rights to
* use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
* the Software, and to permit persons to whom the Software is furnished to do so,
* subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
* FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
* COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
* IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
* CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace TspLibNet
{
    using Tours;

    public enum ProblemType
    {
        TSP,
        ATSP,
        HCP,
        SOP,
        CVRP
    }

    /// <summary>
    /// Interface for a graph based problems
    /// </summary>
    public interface IProblem
    {
        /// <summary>
        /// Represents the problem type (TSP, ATSP, etc).
        /// </summary>
        ProblemType Type { get; }

        /// <summary>
        /// Gets file name - Identifies the data file.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets file comment - additional comments from problem author
        /// </summary>
        string Comment { get; }

        /// <summary>
        /// Gets tour distance for a given problem
        /// </summary>
        /// <param name="tour">Tour to check</param>
        /// <returns>Tour distance</returns>
        double TourDistance(ITour tour);
    }
}