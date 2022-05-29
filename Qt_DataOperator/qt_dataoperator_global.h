#pragma once

#include <QtCore/qglobal.h>

#ifndef BUILD_STATIC
# if defined(QT_DATAOPERATOR_LIB)
#  define QT_DATAOPERATOR_EXPORT Q_DECL_EXPORT
# else
#  define QT_DATAOPERATOR_EXPORT Q_DECL_IMPORT
# endif
#else
# define QT_DATAOPERATOR_EXPORT
#endif
