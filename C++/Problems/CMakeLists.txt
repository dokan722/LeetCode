cmake_minimum_required(VERSION 3.31)
project(Problems)

set(CMAKE_CXX_STANDARD 20)

add_executable(Problems main.cpp
        problem.h
        Problems/problem_1.cpp
        Problems/Problems.h
        Problems/problem_1.h
        resources.cpp
        resources.h
        Problems/problem_3.cpp
        Problems/problem_3.h
        Problems/problem_2.cpp
        Problems/problem_2.h
        Problems/problem_386.cpp
        Problems/problem_386.h
)
